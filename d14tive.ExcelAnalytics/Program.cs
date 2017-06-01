using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpusExplorer.Sdk.Blocks;
using CorpusExplorer.Sdk.Blocks.SelectionCluster.Generator;
using CorpusExplorer.Sdk.Model;
using CorpusExplorer.Sdk.Model.Adapter.Corpus;
using CorpusExplorer.Sdk.Model.Extension;

namespace d14tive.ExcelAnalytics
{
  class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      Console.Write("Select NEWS-Corpus: ");
      var corpus_news = SelectCorpus();
      Console.WriteLine(corpus_news);

      Console.Write("Select TWEET-Corpus: ");
      var corpus_tweet = SelectCorpus();
      Console.WriteLine(corpus_tweet);

      var cec_news = CorpusAdapterWriteDirect.Create(corpus_news);
      var cec_tweet = CorpusAdapterWriteDirect.Create(corpus_tweet);
      Console.WriteLine("CORPORA LOADED");

      //CalculateBasicStatistics(cec_news);
      //CalculateBasicStatistics(cec_tweet);
      //Console.WriteLine("BASIC DONE");

      var cluster_news = GetDateClusters(cec_news);
      var cluster_tweet = GetDateClusters(cec_tweet);

      CalculateInfluence(cluster_news, cec_news.CorpusDisplayname, "Autor");
      CalculateInfluence(cluster_tweet, cec_tweet.CorpusDisplayname, "Absender (Id)");
      Console.WriteLine("INFLUENCE DONE");

      CalculateCountry(cluster_tweet, cec_tweet.CorpusDisplayname);
      Console.WriteLine("DONE");
      Console.ReadLine();
    }

    private static Selection[] GetDateClusters(CorpusAdapterWriteDirect corpus)
    {
      var select = corpus.ToSelection();
      var blockCluster = select.CreateBlock<SelectionClusterBlock>();
      blockCluster.ClusterGenerator = new SelectionClusterGeneratorByDateTimeYearMonthDayOnlyValue();
      blockCluster.MetadataKey = "Datum";
      blockCluster.Calculate();
      return blockCluster.GetSelectionClusters().OrderBy(x => x.Displayname).ToArray();
    }

    private static void CalculateBasicStatistics(CorpusAdapterWriteDirect corpus)
    {
      var stb = new StringBuilder();
      stb.AppendLine($"Dokumente: {corpus.CountDocuments}");
      stb.AppendLine($"Token: {corpus.CountToken}");
      stb.AppendLine($"Types: {corpus.GetLayerValues("Wort").Count()}");

      var autoren = new HashSet<string>();
      var dtMin = DateTime.MaxValue;
      var dtMax = DateTime.MinValue;

      var meta = corpus.DocumentMetadata;
      foreach (var doc in meta)
      {
        if (doc.Value.ContainsKey("Autor"))
          autoren.Add(doc.Value["Autor"]?.ToString());
        if (doc.Value.ContainsKey("Absender (Id)"))
          autoren.Add(doc.Value["Absender (Id)"]?.ToString());
        if (doc.Value.ContainsKey("Datum") && doc.Value["Datum"] is DateTime)
        {
          var date = (DateTime)doc.Value["Datum"];
          if (date == DateTime.MinValue || date == DateTime.MaxValue)
            continue;
          if (date < dtMin)
            dtMin = date;
          if (date > dtMax)
            dtMax = date;
        }
      }

      stb.AppendLine($"Autoren: {autoren.Count}");
      stb.AppendLine($"DT-MIN: {dtMin:yyyy-MM-dd}");
      stb.AppendLine($"DT-MAX: {dtMax:yyyy-MM-dd}");
      File.WriteAllText(corpus.CorpusDisplayname + "_basicStat.csv", stb.ToString());
    }

    private static void CalculateInfluence(Selection[] clusters, string name, string property)
    {
      var stb = new StringBuilder();
      var cnt = new Dictionary<string, double>();

      foreach (var cluster in clusters)
      {
        var block = cluster.CreateBlock<DocumentMetadataWeightBlock>();
        block.Calculate();

        Dictionary<string, double[]> meta;
        try
        {
          meta = block.GetAggregatedRelativeSize(property);
          if (meta == null || meta.Count < 1)
            continue;
        }
        catch { continue; }

        foreach (var x in meta)
        {
          if (cnt.ContainsKey(x.Key))
            cnt[x.Key] += x.Value[0];
          else
            cnt.Add(x.Key, x.Value[0]);
        }

        foreach (var x in cnt)
        {
          stb.AppendLine($"{DateTime.ParseExact(cluster.Displayname, "yyyy-MM-dd", CultureInfo.InvariantCulture)}\t{x.Key}\t{x.Value}");
        }
      }

      File.WriteAllText(name + "_influence.csv", stb.ToString(), Encoding.UTF8);
    }

    private static void CalculateCountry(Selection[] clusters, string name)
    {
      var country = File.ReadAllLines("countries.csv", Encoding.UTF8).Select(x=>x.Split(';')).ToDictionary(x=>x[0], x=>x[1]);
      var stb = new StringBuilder();
      var cnt = new Dictionary<string, double>();

      foreach (var cluster in clusters)
      {
        var block = cluster.CreateBlock<DocumentMetadataWeightBlock>();
        block.Calculate();

        Dictionary<string, double[]> meta;
        try
        {
          meta = block.GetAggregatedRelativeSize("Land");
          if (meta == null || meta.Count < 1)
            continue;
        }
        catch { continue; }

        foreach (var x in meta)
        {
          var key = country.ContainsKey(x.Key.ToUpper()) ? country[x.Key.ToUpper()] : x.Key;

          if (cnt.ContainsKey(key))
            cnt[key] += x.Value[0];
          else
            cnt.Add(key, x.Value[0]);
        }

        foreach (var x in cnt)
        {
          stb.AppendLine($"{DateTime.ParseExact(cluster.Displayname, "yyyy-MM-dd", CultureInfo.InvariantCulture)}\t{x.Key}\t{x.Value}");
        }
      }

      File.WriteAllText(name + "_country.csv", stb.ToString(), Encoding.UTF8);
    }

    private static string SelectCorpus()
    {
      var ofd = new OpenFileDialog
      {
        Filter = "CEC6-Corpus|*.cec6",
        CheckFileExists = true,
        Multiselect = false
      };
      ofd.ShowDialog();
      return ofd.FileName;
    }
  }
}
