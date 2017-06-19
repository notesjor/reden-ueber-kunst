using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CorpusExplorer.Tool4.documenta14.BruteForceCrawler
{
  class Program
  {
    static void Main(string[] args)
    {
      Parallel.For(
        1,
        10000,
        (i) =>
        {
          var output = $"de_{i:D5}.html";
          if (File.Exists(output) && new FileInfo(output).Length > 5)
            return;

          var wc = new WebClient();
          try
          {
            wc.DownloadFile($"http://www.documenta14.de/de/south/{i}", output);
          }
          catch (WebException web)
          {
            var webResponse = web.Response as HttpWebResponse;
            if (webResponse == null)
              return;

            File.WriteAllText(output, $"ERROR:{webResponse.StatusCode}");
          }
          finally
          {
            wc.Dispose();
          }
        });
    }
  }
}
