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
using DotNetBrowser.WinForms;

namespace d14tive.WindowsClient.Pages.Web
{
  public partial class PageWeb : AbstractPage
  {
    private WinFormsBrowserView webBrowser1;

    public PageWeb()
    {
      InitializeComponent();

      webBrowser1 = new WinFormsBrowserView(MyConfiguration.Browser);
      SuspendLayout();
      webBrowser1.Dock = DockStyle.Fill;
      webBrowser1.Location = new Point(0, 0);
      webBrowser1.Name = "webBrowser1";
      webBrowser1.Size = Size;
      webBrowser1.TabIndex = 0;
      Controls.Add(webBrowser1);
      ResumeLayout(false);
    }

    public string Url { get; set; }

    public override void ShowPage()
    {
      webBrowser1.Browser.LoadURL(Url);
    }
  }
}
