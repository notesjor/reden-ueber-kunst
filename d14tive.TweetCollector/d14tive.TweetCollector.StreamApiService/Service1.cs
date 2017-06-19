using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;

namespace CorpusExplorer.Tool4.TwitterDumpDocumentaService
{
  public partial class Service1 : ServiceBase
  {
    private static Timer _timer;

    public Service1() { InitializeComponent(); }

    protected override void OnStart(string[] args)
    {
      ProcessStart();
      _timer = new Timer(
        obj =>
        {
          var process = ProcessFind();
          if (process == null)
          {
            ProcessStart();
            return;
          }
          if (process.WorkingSet64 <= 272243712)
            return;
          ProcessClose(process);
          ProcessStart();
        },
        null,
        5000,
        5000);
    }

    protected override void OnStop() { ProcessClose(ProcessFind()); }

    private void ProcessClose(Process process)
    {
      if (process == null)
        return;
      try
      {
        process.Close();
      }
      catch {}
      try
      {
        process.Kill();
      }
      catch {}
    }

    private Process ProcessFind()
    {
      var processes = Process.GetProcessesByName("CorpusExplorer.Tool4.TwitterDump");
      switch (processes.Length)
      {
        case 0:
          return null;
        case 1:
          return processes[0];
        default:
          foreach (var process in processes)
            ProcessClose(process);
          return null;
      }
    }

    private void ProcessStart()
    {
      Process.Start(
        new ProcessStartInfo
        {
          FileName = @"C:\d14\CorpusExplorer.Tool4.TwitterDump.exe",
          Arguments = @"C:\d14\list.csv",
          CreateNoWindow = true,
          UseShellExecute = false,
          RedirectStandardOutput = false,
          WindowStyle = ProcessWindowStyle.Hidden,
          WorkingDirectory = @"C:\d14\"
        });
    }
  }
}