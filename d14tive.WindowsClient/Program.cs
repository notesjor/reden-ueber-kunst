using System;
using System.Linq;
using System.Windows.Forms;
using d14tive.WindowsClient.Forms;

namespace d14tive.WindowsClient
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}