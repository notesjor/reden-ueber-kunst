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
    }

    private void Initialize()
    {
      if (_init)
        return;

      _corpus = CorpusAdapterWriteDirect.Create(@"tweets.cec6");
      _dsel = new List<Guid>(_corpus.DocumentGuids);
      _rnd = MyConfiguration.Random;
      timer1_Tick(null, null);
      timer1.Start();

      _init = true;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (_dsel.Count < _controls.Count)
        _dsel = new List<Guid>(_corpus.DocumentGuids);

      var nlist = new List<Guid>();
      for (var i = 0; i < _controls.Count; i++)
      {
        var idx = _rnd.Next(0, _dsel.Count);
        nlist.Add(_dsel[idx]);
        _dsel.RemoveAt(idx);
      }

      for (var i = 0; i < nlist.Count; i++)
      {

        try
        {
          var dsel = nlist[i];
          var meta = _corpus.GetDocumentMetadata(dsel);

          _controls[i].Content = _corpus.GetReadableDocument(dsel, "Wort");
          _controls[i].Date = ((DateTime) meta["Datum"]).ToString("yyyy-MM-dd HH:mm:ss");
          _controls[i].Username = meta["Absender (Name)"]?.ToString();
        }
        catch
        {
          // ignore
        }
      }
    }
  }
}
