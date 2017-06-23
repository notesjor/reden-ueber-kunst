using System;
using System.Collections.Generic;
using d14tive.WindowsClient.Controls.Abstract;

namespace d14tive.WindowsClient.Controls
{
  public partial class TweetControl : AbstractUserControl
  {
    public TweetControl()
    {
      InitializeComponent();
    }
    
    public IEnumerable<IEnumerable<string>> Content
    {
      set => wpfTagger1.Text = value;
    }
  }
}