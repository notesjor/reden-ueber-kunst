using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpusExplorer.Core.Exporter;
using CorpusExplorer.Sdk.Model.Adapter.Corpus;
using CorpusExplorer.Sdk.Model.Extension;

namespace d14tive.TweetsToCsv
{
  class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      var ofd = new OpenFileDialog { Filter = "CEC6-Korpus|*.cec6", Multiselect = false, CheckFileExists = true };
      Console.Write("Select corpus file: ");
      ofd.ShowDialog();

      var corpus = CorpusAdapterWriteDirect.Create(ofd.FileName);
      Console.WriteLine(ofd.FileName);
      Console.WriteLine($"{corpus.CountDocuments} tweets");

      var guids = OriginalTweetFilter.GetOriginalTweets(corpus);

      Console.WriteLine($"{guids.Count} tweets matches all criteria");

      var all = corpus.ToSelection();
      var selection = all.Create(guids, "");
      var exporter = new ExporterCsv();

      exporter.Export(selection, ofd.FileName.Replace(".cec6", ".csv"));
      Console.WriteLine("!END!");
      Console.ReadLine();
    }
  }
}
