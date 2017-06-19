using CorpusExplorer.Sdk.Ecosystem;
using CorpusExplorer.Sdk.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpusExplorer.Sdk.Extern.Json.TwitterStream;

namespace CorpusExplorer.Tool4.documenta14.DirectoryCleaner
{
  class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      CorpusExplorerEcosystem.InitializeMinimal();

      var fbd = new FolderBrowserDialog { Description = "JSON-Folder" };
      if (fbd.ShowDialog() != DialogResult.OK)
        return;

      var sfd = new FolderBrowserDialog { Description = "Output-Folder" };
      if (sfd.ShowDialog() != DialogResult.OK)
        return;

      var packages = MakeFilePackages(Directory.GetFiles(fbd.SelectedPath, "*.json", SearchOption.TopDirectoryOnly));

      Parallel.For(
        0,
        packages.Count,
        i =>
        {
          try
          {
            var package = packages[i];

            var sdd_en = new List<Dictionary<string, object>>();
            var sdd_de = new List<Dictionary<string, object>>();
            var sdd_el = new List<Dictionary<string, object>>();

            foreach (var file in package)
            {
              var scraper = new TwitterScraper();
              scraper.Input.Enqueue(file);
              scraper.Execute();

              var output = scraper.Output.ToArray();

              var valid = false;
              foreach (var x in output)
              {
                if (!x.ContainsKey("Sprache"))
                  continue;

                switch (x["Sprache"].ToString())
                {
                  case "en":
                    sdd_en.Add(x);
                    valid = true;
                    break;
                  case "de":
                    sdd_de.Add(x);
                    valid = true;
                    break;
                  case "el":
                    sdd_el.Add(x);
                    valid = true;
                    break;
                }
              }

              if (valid)
                continue;

              try
              {
                File.Delete(file);
              }
              catch { }
            }

            Serializer.Serialize(sdd_en.ToArray(), Path.Combine(sfd.SelectedPath, $"tweets_en_{i:D3}.sdd"), true);
            Serializer.Serialize(sdd_de.ToArray(), Path.Combine(sfd.SelectedPath, $"tweets_de_{i:D3}.sdd"), true);
            Serializer.Serialize(sdd_el.ToArray(), Path.Combine(sfd.SelectedPath, $"tweets_el_{i:D3}.sdd"), true);
          }
          catch (Exception ex)
          {
            Console.WriteLine(ex.Message);
            Console.WriteLine("-----------");
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine("-----#-----");
          }
        });

      Console.WriteLine("! END !");
      Console.ReadLine();
    }

    private static List<string[]> MakeFilePackages(string[] files)
    {
      Console.WriteLine($"{files.Length} files found!");

      var packages = new List<string[]>();
      var current = new List<string>(10000);
      for (var i = 0; i < files.Length; i++)
      {
        if ((i > 0) && (i % 10000 == 0))
        {
          packages.Add(current.ToArray());
          current.Clear();
        }
        current.Add(files[i]);
      }
      if (current.Count > 0)
        packages.Add(current.ToArray());

      Console.WriteLine($"{packages.Count} packages generated!");

      return packages;
    }
  }
}
