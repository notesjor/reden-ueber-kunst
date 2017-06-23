using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpusExplorer.Sdk.Model.Adapter.Corpus;
using d14tive.WindowsClient.Controls;
using d14tive.WindowsClient.Pages.Abstract;
using d14tive.WindowsClient.Pages.App.CurrentTweets.Model;

namespace d14tive.WindowsClient.Pages.App.CurrentTweets
{
  public partial class CurrentTweetPage : AbstractPage
  {
    private bool _init;
    private List<TweetGroup> _groups = new List<TweetGroup>();
    private List<TweetGroup> _stack;
    private Random _rnd;
    private TweetControl[] _controls;

    public CurrentTweetPage()
    {
      InitializeComponent();
      Timer = 15000;
      lbl_info.Text = "Tweets zur #documenta14";

      _controls = new []
      {
        tweetControl1, tweetControl2, tweetControl3, tweetControl4, tweetControl5
      };
    }

    public override void ShowPage(Size size)
    {
      centerControl1.Adjust(size);
      Initialize();
      timer1_Tick(null, null);
    }

    private void Initialize()
    {
      if (_init)
        return;

      var lines = File.ReadAllLines("tweets.txt", Encoding.UTF8);
      TweetGroup group = null;
      foreach (var line in lines)
      {
        if (group == null)
        {
          if (string.IsNullOrWhiteSpace(line))
            continue;
          group = new TweetGroup { Topic = lbl_info.Text };
        }

        if (string.IsNullOrWhiteSpace(line))
        {
          if (group.Entries.Count >= 5)
            _groups.Add(group);
          group = null;
          continue;
        }

        group.Entries.Add(new TweetEntry {Text = line});
      }

      if (group != null && group.Entries.Count >= 5)
        _groups.Add(group);

      _stack = new List<TweetGroup>(_groups);
      _rnd = MyConfiguration.Random;
      
      _init = true;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (_stack.Count < 1)
        _stack = new List<TweetGroup>(_groups);

      var idx = _rnd.Next(0, _stack.Count);
      var grp = _groups[idx];
      _stack.RemoveAt(idx);

      lbl_info.Text = grp.Topic;

      var twt = new List<TweetEntry>(grp.Entries);
      foreach (var c in _controls)
      {
        try
        {
          var twidx = _rnd.Next(0, twt.Count);
          var tweet = twt[twidx];
          twt.RemoveAt(twidx);

          c.Content = new List<string[]> {tweet.Text.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)};
          //c.Date = ((DateTime)meta["Datum"]).ToString("yyyy-MM-dd HH:mm:ss");
          //c.Username = meta["Absender (Name)"]?.ToString();
        }
        catch
        {
          // ignore
        }
      }
    }
  }
}
