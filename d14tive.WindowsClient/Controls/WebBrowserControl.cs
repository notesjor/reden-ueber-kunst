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
using d14tive.WindowsClient.Controls.Abstract;
using DotNetBrowser.WinForms;

namespace d14tive.WindowsClient.Controls
{
  public partial class WebBrowserControl : AbstractUserControl
  {
    private WinFormsBrowserView _webBrowser1;

    public WebBrowserControl()
    {
      InitializeComponent();

      _webBrowser1 = new WinFormsBrowserView(MyConfiguration.Browser);
      SuspendLayout();
      _webBrowser1.HorizontalScroll.Enabled = false;
      _webBrowser1.VerticalScroll.Enabled = false;
      _webBrowser1.Dock = DockStyle.Fill;
      _webBrowser1.Location = new Point(0, 0);
      _webBrowser1.Name = "webBrowser1";
      _webBrowser1.Size = Size;
      _webBrowser1.TabIndex = 0;
      Controls.Add(_webBrowser1);
      ResumeLayout(false);
    }

    public void LoadUrl(string url)
    {
      _webBrowser1.Browser.LoadURL(url);
    }

    public void LoadHtmlFromFile(string path)
    {
      var html = File.ReadAllText(path, Encoding.UTF8);
      _webBrowser1.Browser.LoadHTML(html);
    }
  }
}
