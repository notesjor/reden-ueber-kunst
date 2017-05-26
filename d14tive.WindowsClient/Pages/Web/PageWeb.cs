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
    public PageWeb()
    {
      InitializeComponent();
    }

    public string Url { get; set; }

    public override void ShowPage(Size size)
    {
      webBrowserControl1.LoadUrl(Url);
    }
  }
}
