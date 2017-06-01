using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using d14tive.WindowsClient.Pages.Abstract;
using d14tive.WindowsClient.Processor;

namespace d14tive.WindowsClient.Pages.App.CurrentTweets
{
  public partial class CurrentTweetPage : AbstractPage
  {
    private TwitterProcessor _processor;
    private Task _task;

    public CurrentTweetPage()
    {
      InitializeComponent();
      _processor = new TwitterProcessor(tweetControl1, tweetControl2, tweetControl3);
      _task = _processor.Run();
      lbl_info.Text = "Live-Tweets zur #documenta14";
    }

    public override void ShowPage(Size size)
    {
      centerControl1.Adjust(size);
    }
  }
}
