using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using d14tive.WindowsClient.Pages.Abstract;

namespace d14tive.WindowsClient.Pages.App.WordCloud
{
  public partial class WordCloudPage : AbstractPage
  {
    private string _appDir;
    private bool _init = false;

    public WordCloudPage(string appDir)
    {
      InitializeComponent();
      _appDir = appDir;
    }

    public override void ShowPage(Size size)
    {
      if (_init)
        return;
      webBrowserControl1.LoadHtmlFromFile(Path.Combine(_appDir, "wordcloud.page"));
      _init = true;
    }
  }
}