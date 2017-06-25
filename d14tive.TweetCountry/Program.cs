using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpusExplorer.Sdk.Extern.Json.TwitterStream;
using CorpusExplorer.Sdk.Helper;

namespace d14tive.TweetCountry
{
  class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      var fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() != DialogResult.OK)
        return;

      var files = Directory.GetFiles(fbd.SelectedPath, "*.json");
      Console.WriteLine($"{files.Length} files");

      var scraper = new TwitterCountryScraper();
      scraper.Input.Enqueue(files);
      scraper.Execute();

      Console.WriteLine($"{scraper.Output.Count} tweets found");
      var countries = GetCountries();
      var hash = SHA256.Create();
      var res = new Dictionary<string, string>(); // Key = Base64-HASH | 0 = Geo, 1 = Datum, 2 = Ländercode2, 3 = Ländercode3

      while (scraper.Output.Count > 0)
      {
        var tweet = new Dictionary<string, object>();
        if (!scraper.Output.TryDequeue(out tweet))
          continue;

        if (!tweet.ContainsKey("Text") || tweet["Text"] == null)
          continue;

        var key = Convert.ToBase64String(hash.ComputeHash(Encoding.UTF8.GetBytes(tweet["Text"].ToString())));
        if (res.ContainsKey(key))
          continue;

        var text = tweet["Text"].ToString().ToLower();
        var athen = text.Contains("athen");
        var kassel = text.Contains("kassel");
        var documenta = text.Contains("documenta");
        var both = athen && kassel;

        string l1 = "", l2 = "";
        if (tweet.ContainsKey("Geo") && tweet["Geo"].ToString().Contains(";"))
        {
          var split = tweet["Geo"].ToString().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
          if (split.Length == 2)
          {
            l1 = split[0];
            l2 = split[1];
          }
        }

        res.Add(key, $"{athen}\t{kassel}\t{both}\t{documenta}\t{l1}\t{l2}\t{tweet["Datum"]}\t{tweet["Ländercode"]}\t{ConvertCountryCode(ref countries, tweet["Ländercode"])}");
      }

      Console.WriteLine($"{res.Count} unique tweets found");

      File.WriteAllLines("output.csv", res.Select(x => $"{x.Key}\t{x.Value}"));

      Console.WriteLine("!END!");
      Console.ReadLine();
    }

    private static string ConvertCountryCode(ref Dictionary<string, string> countries, object o)
    {
      return o == null ? "" : (countries.ContainsKey(o.ToString()) ? countries[o.ToString()] : "");
    }

    private static Dictionary<string, string> GetCountries()
    {
      var lines = File.ReadAllLines("countries.csv");
      return lines.Select(line => line.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries)).Where(items => items.Length == 2).ToDictionary(items => items[0], items => items[1]);
    }
  }
}
