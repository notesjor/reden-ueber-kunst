using CorpusExplorer.Sdk.Ecosystem;
using CorpusExplorer.Sdk.Ecosystem.Model;
using CorpusExplorer.Sdk.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CorpusExplorer.Tool4.documenta14.FileScraper
{
  class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      CorpusExplorerEcosystem.InitializeMinimal();

      var fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() != DialogResult.OK)
        return;

      var files = Directory.GetFiles(fbd.SelectedPath, "*.html");
      var valid = new List<string>();
      // Die guten ins Töpfchen, die schlechten ins Kröpfchen
      foreach (var f in files)
      {
        if ((new FileInfo(f)).Length < 4096)
          File.Delete(f);
        else
          valid.Add(f);
      }

      var scrap = new List<Dictionary<string, object>>();
      foreach (var f in valid)
      {
        var doc = new HtmlAgilityPack.HtmlDocument();
        doc.Load(f, Configuration.Encoding);
        var res = new Dictionary<string, object>
        {
          {"Titel", doc.DocumentNode.SelectSingleNode("/html/head/meta[@property='og:title']")?.GetAttributeValue("content", "")},
          {"Type", doc.DocumentNode.SelectSingleNode("/html/head/meta[@property='og:type']")?.GetAttributeValue("content", "")},
          {"URL", doc.DocumentNode.SelectSingleNode("/html/head/meta[@property='og:url']")?.GetAttributeValue("content", "")},
          {"Autor", doc.DocumentNode.SelectSingleNode("/html/body/main/div/div[@class='article-authors']")?.InnerText?.Replace("Von ","") }
        };

        var trans = doc.DocumentNode.SelectNodes("//em");
        if (trans != null)
          foreach (var n in trans)
          {
            var txt = n.InnerText;
            if (!txt.StartsWith("Aus dem Englischen von "))
              continue;
            res.Add("Übersetzer", txt.Replace("Aus dem Englischen von ", ""));
            n.ParentNode.RemoveChild(n);
            break;
          }

        DeleteNode(ref doc, "//a");

        DeleteNode(ref doc, "/html/body/header");
        DeleteNode(ref doc, "/html/body/main/div/section[@class='article-footnotes']");

        DeleteNode(ref doc, "//div[@class='article-authors']");
        DeleteNode(ref doc, "//div[@class='article-title header-title']");
        DeleteNode(ref doc, "//div[@class='article-quotes']");
        DeleteNode(ref doc, "//div[@class='article-sticky-image-group']");
        DeleteNode(ref doc, "//div[@class='article-image']");
        DeleteNode(ref doc, "//div[@class='article-image-single article-image-single-medium article-image-single-landscape']");
        DeleteNode(ref doc, "//div[@class='article-image-single article-image-single-large article-image-single-landscape']");
        DeleteNode(ref doc, "//div[@class='article-image-single article-image-single-large article-image-single-portrait']");

        var main = doc.DocumentNode.SelectSingleNode("/html/body/main");

        res.Add("Text", main.InnerText);
        scrap.Add(res);
      }

      Serializer.Serialize(scrap.ToArray(), "output.sdd", true);
    }

    private static void DeleteNode(ref HtmlAgilityPack.HtmlDocument doc, string xpath)
    {
      var del = doc.DocumentNode.SelectNodes(xpath)?.ToArray();
      if (del == null)
        return;

      foreach (var n in del)
      {
        try
        {
          n.ParentNode.RemoveChild(n);
        }
        catch { }
      }
    }
  }
}
