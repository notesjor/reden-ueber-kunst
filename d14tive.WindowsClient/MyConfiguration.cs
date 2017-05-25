using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetBrowser;

namespace d14tive.WindowsClient
{
  public static class MyConfiguration
  {
    public static int PageTimeout { get; } = 16000;

    public static Browser Browser = BrowserFactory.Create(BrowserType.HEAVYWEIGHT);
  }
}
