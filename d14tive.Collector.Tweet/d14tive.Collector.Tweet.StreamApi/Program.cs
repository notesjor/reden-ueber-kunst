#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LinqToTwitter;

#endregion

namespace CorpusExplorer.Tool4.TwitterDump
{
  internal class Program
  {
    private static TwitterContext _context;
    private static string _name;
    private static string _outputpath;
    private static string _query;

    private static InMemoryCredentialStore GetCredential()
    {
      return new InMemoryCredentialStore
      {
	// ToDO
        ConsumerKey =
          "{ENTER CONSUMER KEY HERE}",
        ConsumerSecret =
          "{ENTER CONSUMER SECRET HERE}",
        OAuthToken = "{ENTER OAUTH-TOKEN HERE}",
        OAuthTokenSecret =
          "{ENTER OAUTH-SECRET HERE}",
        ScreenName = "CE-Reader",
        UserID = // ENTER USERID HERE
      };
    }

    [STAThread]
    private static void Main(string[] args)
    {
      var hashtags = File.ReadAllLines(args.Length < 1 ? "list.csv" : args[0], Encoding.UTF8);

      _name = hashtags[0].Replace("#", "").Replace("@", "");
      _query = string.Join(",", hashtags);
      _context = new TwitterContext(new SingleUserAuthorizer {CredentialStore = GetCredential()});
      _outputpath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), _name);

      if (!Directory.Exists(_outputpath))
        Directory.CreateDirectory(_outputpath);

      var task = StreamTwitterContent();
      Console.WriteLine("ok!");

      while (true)
      {
        Thread.Sleep(15000);
        GC.Collect();
      }

      task.Wait();
    }

    private static Task<List<Streaming>> StreamTwitterContent()
    {
      Console.Write($"{_name}...");
      return (from strm in _context.Streaming
              where (strm.Type == StreamingType.Filter) && (strm.Track == _query)
              select strm).StartAsync(
        async strm =>
        {
          try
          {
            if (strm == null)
              return;

            var content = strm.Content;
            if (!string.IsNullOrEmpty(content))
              try
              {
                var stamp = DateTime.Now.ToString("O").Replace(":", "-");

                using (
                  var fs = new FileStream(
                    Path.Combine(_outputpath, stamp + ".json"),
                    FileMode.Create,
                    FileAccess.Write))
                {
                  var buffer = Encoding.UTF8.GetBytes(content);
                  fs.Write(buffer, 0, buffer.Length);
                }

                Console.WriteLine($"{_name}: {stamp}");
              }
              catch (Exception ex)
              {
                Console.WriteLine($"{_name} - 01: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
              }
          }
          catch (Exception ex)
          {
            Console.WriteLine($"{_name} - 02: {ex.Message}");
            Console.WriteLine(ex.StackTrace);
          }
        });
    }
  }
}