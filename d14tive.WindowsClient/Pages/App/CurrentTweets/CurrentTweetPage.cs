using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CorpusExplorer.Sdk.Model.Adapter.Corpus;
using d14tive.WindowsClient.Controls;
using d14tive.WindowsClient.Pages.Abstract;

namespace d14tive.WindowsClient.Pages.App.CurrentTweets
{
  public partial class CurrentTweetPage : AbstractPage
  {
    private bool _init;
    private CorpusAdapterWriteDirect _corpus;
    private List<Guid> _dsel;
    private Random _rnd;
    private List<TweetControl> _controls;

    public CurrentTweetPage()
    {
      InitializeComponent();
      lbl_info.Text = "Eine subjektive Auswahl von Tweets zur #documenta14";

      _controls = new List<TweetControl>
      {
        tweetControl1, tweetControl2, tweetControl3
      };
    }

    public override void ShowPage(Size size)
    {
      centerControl1.Adjust(size);
      Initialize();

      if (_dsel.Count < 3)
        _dsel = new List<Guid>(_corpus.DocumentGuids);

      var nlist = new List<Guid>();
      for (var i = 0; i < 3; i++)
      {
        var idx = _rnd.Next(0, _dsel.Count);
        nlist.Add(_dsel[idx]);
        _dsel.RemoveAt(idx);
      }

      for (int i = 0; i < nlist.Count; i++)
      {
        var dsel = nlist[i];
        var meta = _corpus.GetDocumentMetadata(dsel);

        _controls[i].Content = _corpus.GetReadableDocument(dsel, "Wort");
        _controls[i].UserAccountname = "@" + meta["Absender (Anzeigename)"];
        _controls[i].UserDisplayname = meta["Absender (Name)"]?.ToString();
        _controls[i].Statistics = $"{meta["Absender (Follower)"]} Follower | {meta["Absender (Tweets)"]} Tweets";        
      }
    }

    private void Initialize()
    {
      if (_init)
        return;

      _corpus = CorpusAdapterWriteDirect.Create(@"tweets.cec6");
      _dsel = new List<Guid>(_corpus.DocumentGuids);
      _rnd = MyConfiguration.Random;

      _init = true;
    }
  }
}
