using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpusExplorer.Sdk.Extern.Json.TwitterStream.Model;
using CorpusExplorer.Sdk.Extern.Json.TwitterStream.Reader;
using d14tive.WindowsClient.Pages.App.CurrentTweets;
using LinqToTwitter;
using Newtonsoft.Json;

namespace d14tive.WindowsClient.Processor
{
  public class TwitterProcessor
  {
    private readonly TweetControl _tcEn;
    private readonly TweetControl _tcDe;
    private readonly TweetControl _tcEl;

    private static TwitterContext _context;
    private static string _query;

    public TwitterProcessor(TweetControl tcEN, TweetControl tcDE, TweetControl tcEL)
    {
      _tcEn = tcEN;
      _tcDe = tcDE;
      _tcEl = tcEL;
    }

    private static InMemoryCredentialStore GetCredential()
    {
      return new InMemoryCredentialStore
      {
        ConsumerKey = "1LBjQd3lugPczSOARJIytjxPU",
        ConsumerSecret = "OEKP7j96o4lJOzqW9fgQjhEdbbICYSHj0OBRT3m0mPBZe9nL5e",
        OAuthToken = "2382676952-uwSzKN6GhDvP4tC53QJgeTwaOP7KtH5JkwiLhre",
        OAuthTokenSecret = "RDnbGkldWMOiXmSGN9GypXx5rvF5LoW3VAFlSTHyxWsVo",
        ScreenName = "d14tive",
        UserID = 2382676952
      };
    }

    public async Task Run()
    {
      var hashtags = new HashSet<string>{"#documenta14","#d14","#Documenta14","#DOCUMENTA14"};
      _query = string.Join(",", hashtags);
      _context = new TwitterContext(new SingleUserAuthorizer { CredentialStore = GetCredential() });
      StreamTwitterContent();
    }

    private Task<List<Streaming>> StreamTwitterContent()
    {
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
                var tweet = JsonConvert.DeserializeObject<StreamMessage>(content);
                if (tweet.PossiblySensitive)
                  return;

                if (IsTweetAlreadyKnown(tweet.Text))
                  return;

                switch (tweet.Lang) {
                  case "en":
                    _tcEn.Invoke((MethodInvoker) delegate
                    {
                      SetTweetControl(_tcEn, tweet);
                    });
                    break;
                  case "de":
                    _tcDe.Invoke((MethodInvoker) delegate
                    {
                      SetTweetControl(_tcDe, tweet);
                      _tcDe.Visible = true;
                    });
                    break;
                  case "el":
                    _tcEl.Invoke((MethodInvoker) delegate
                    {
                      SetTweetControl(_tcEl, tweet);
                      _tcEl.Visible = true;
                    });
                    break;
                }
              }
              catch (Exception ex)
              {
                // ignore
              }
          }
          catch (Exception ex)
          {
            // ignore
          }
        });
    }

    private HashSet<string> _knownTweets = new HashSet<string>();
    private object _knownTweetsLock = new object();
    private MD5 _md5 = MD5.Create();

    private bool IsTweetAlreadyKnown(string tweetText)
    {
      try
      {
        var hash = Convert.ToBase64String(_md5.ComputeHash(Encoding.UTF8.GetBytes(tweetText)));
        lock (_knownTweetsLock)
        {
          if (_knownTweets.Contains(hash))
            return true;

          if (_knownTweets.Count > 5000)
            _knownTweets.Clear();
          _knownTweets.Add(hash);

          return false;
        }
      }
      catch { return true; }
    }

    private void SetTweetControl(TweetControl tc, StreamMessage tweet)
    {
      tc.UserAccountname = "@"+tweet.User.ScreenName;
      tc.UserDisplayname = tweet.User.Name;
      tc.Content = tweet.Text;
      tc.Statistics = $"{tweet.User.FollowersCount} Follower | {tweet.User.StatusesCount} Tweets";
    }
  }
}
