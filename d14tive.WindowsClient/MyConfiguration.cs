using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetBrowser;
using Telerik.WinControls.UI;

namespace d14tive.WindowsClient
{
  public static class MyConfiguration
  {
    public static int PageTimeout { get; } = 16000;
    public static Random Random { get; set; } = new Random(DateTime.Now.Millisecond * DateTime.Now.Second);
    public static Browser Browser = BrowserFactory.Create(BrowserType.HEAVYWEIGHT);
  }
}
