using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bcs.IO;

namespace d14tive.TweetSelectorByUrl
{
  internal class Program
  {
    [STAThread]
    private static void Main(string[] args)
    {
      var ofd1 = new OpenFileDialog {Filter = "TSV-Datei (*.txt)|*.txt"};
      ofd1.ShowDialog();

      var ofd2 = new OpenFileDialog {Filter = "TXT-URL-Liste (*.txt)|*.txt"};
      ofd2.ShowDialog();

      var csv = FileIO.ReadLines(ofd1.FileName);
      var url = FileIO.ReadLines(ofd2.FileName).Where(x => !string.IsNullOrWhiteSpace(x));

      var res = new List<string>();

      foreach (var x in url)
      foreach (var y in csv)
      {
        if (!y.Contains(x))
          continue;
        var s = y.Split(new[] {"\t"}, StringSplitOptions.RemoveEmptyEntries);
        res.Add(s[s.Length - 1]);
        break;
      }

      FileIO.Write(ofd1.FileName + ".txt", res.ToArray());
    }
  }
}