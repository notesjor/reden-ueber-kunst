﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using d14tive.WindowsClient.Pages.Abstract;

namespace d14tive.WindowsClient.Pages.App.CurrentTweets
{
  public partial class CurrentTweetPage : AbstractPage
  {
    public CurrentTweetPage()
    {
      InitializeComponent();
    }

    public override void ShowPage(Size size) { centerControl1.Adjust(size); }
  }
}
