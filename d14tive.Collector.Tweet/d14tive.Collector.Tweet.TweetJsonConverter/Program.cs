using CorpusExplorer.Core.DocumentProcessing.Tagger.RawText;
using CorpusExplorer.Core.DocumentProcessing.Tokenizer;
using CorpusExplorer.Sdk.Ecosystem;
using CorpusExplorer.Sdk.Helper;
using CorpusExplorer.Sdk.Utils.DocumentProcessing.Builder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CorpusExplorer.Tool4.documenta.Converter
{
  internal class Program
  {
    [STAThread]
    private static void Main(string[] args)
    {
      CorpusExplorerEcosystem.InitializeMinimal();

      var fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() != DialogResult.OK)
        return;

      var languages = new[] { "de", "en", "el" };
      foreach (var language in languages)
      {
        var files = Directory.GetFiles(fbd.SelectedPath, $"tweets_{language}_*.sdd");
        Console.WriteLine($"{language} with {files.Length} clusters");

        var hashes = new HashSet<string>();

        var tagger = new RawTextTagger
        {
          CorpusBuilder = new CorpusBuilderWriteDirect(),
          Tokenizer = new HighSpeedSpaceTokenizer()
        };

        var all = 0;

        foreach (var file in files)
        {
          var sdd = Serializer.Deserialize<Dictionary<string, object>[]>(file);
          all += sdd.Length;

          using (var hash = SHA256.Create())
            foreach (var x in sdd)
            {
              if (!x.ContainsKey("Text"))
                continue;

              try
              {
                var tHash = Convert.ToBase64String(hash.ComputeHash(Encoding.UTF8.GetBytes(x["Text"].ToString())));
                if (hashes.Contains(tHash))
                  continue;
                hashes.Add(tHash);

                tagger.Input.Enqueue(x);
              }
              catch
              { //ignore
              }
            }
        }

        Console.WriteLine($"{language} has {all} tweets - {all - hashes.Count} copy-cats - {hashes.Count} original tweets");

        tagger.Execute();
        tagger.Output.First().Save(Path.Combine(fbd.SelectedPath, $"tweets_{language}.cec6"));

        Console.WriteLine(language + "...ok!");
      }

      Console.WriteLine("! END !");
      Console.ReadLine();
    }
  }
}