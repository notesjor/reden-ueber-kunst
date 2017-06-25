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
    private static int _zeitungenMax = 0;

    [STAThread]
    static void Main(string[] args)
    {
      Console.Write("How many corpora?: ");
      var max = int.Parse(Console.ReadLine());

      for (int i = 0; i < max; i++)
      {
        Console.Write("Corpus type (t=tweet / n=news): ");
        var type = Console.ReadLine();

        Console.Write("Select corpus: ");
        var corpus = SelectCorpus();
        Console.Write(corpus);

        var cec = CorpusAdapterWriteDirect.Create(corpus);
        Console.WriteLine("...ok!");

        CalculateBasicStatistics(cec);
        Console.WriteLine("BASIC DONE");

        var cluster = GetDateClusters(cec);

        if (type == "n")
        {
          CalculateNewspapersAllIn(cluster);
          CalculateInfluence(cluster, cec.CorpusDisplayname, "Zeitung");
        }
        if (type == "t")
        {
          CalculateInfluence(cluster, cec.CorpusDisplayname, "Absender (Id)");
        }

        Console.WriteLine("DONE");
        Console.ReadLine();
      }
    }

    private static void CalculateNewspapersAllIn(Selection[] clusterNews)
    {
      var outputAt = new Queue<double>();
      outputAt.Enqueue(0.80);
      outputAt.Enqueue(0.90);
      outputAt.Enqueue(0.95);
      outputAt.Enqueue(0.99);
      outputAt.Enqueue(1.00);

      var hash = new HashSet<string>();
      var outA = outputAt.Dequeue();
      var outC = outA * _zeitungenMax;
      foreach (var c in clusterNews)
      {
        var meta = c.DocumentMetadata;
        foreach (var pair in meta)
          if (pair.Value.ContainsKey("Zeitung"))
            hash.Add(pair.Value["Zeitung"]?.ToString());

        if (hash.Count < outC)
          continue;

        Console.WriteLine($"{((int)(outA * 100.0)):D3}% Zeitungen erreicht am {c.Displayname}");
        if (outputAt.Count == 0)
          break;

        outA = outputAt.Dequeue();
        outC = outA * _zeitungenMax;
      }
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
      var zeitung = new HashSet<string>();
      var dtMin = DateTime.MaxValue;
      var dtMax = DateTime.MinValue;

      var meta = corpus.DocumentMetadata;
      foreach (var doc in meta)
      {
        if (doc.Value.ContainsKey("Autor"))
          autoren.Add(doc.Value["Autor"]?.ToString());
        if (doc.Value.ContainsKey("Zeitung"))
          zeitung.Add(doc.Value["Zeitung"]?.ToString());
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
      stb.AppendLine($"Zeitungen: {zeitung.Count}");
      if (zeitung.Count > _zeitungenMax)
        _zeitungenMax = zeitung.Count;

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
