using System;
using System.Diagnostics;
using System.IO;

namespace CorpusExplorer.Tool4.documenta14.AutoGit
{
  class Program
  {
    static void Main(string[] args)
    {
      Directory.SetCurrentDirectory(@"C:\Users\Administrator\Desktop\bitbucket\d14web\documenta14webDE");
      SafeCall(
        () =>
        {
          var si = new ProcessStartInfo { FileName = @"C:\Program Files\WinHTTrack\httrack.exe", Arguments = "--update" };
          var pr = Process.Start(si);
          pr.WaitForExit();
        });

      Directory.SetCurrentDirectory(@"C:\Users\Administrator\Desktop\bitbucket\d14web\documenta14webEN");
      SafeCall(
        () =>
        {
          var si = new ProcessStartInfo { FileName = @"C:\Program Files\WinHTTrack\httrack.exe", Arguments = "--update" };
          var pr = Process.Start(si);
          pr.WaitForExit();
        });

      Directory.SetCurrentDirectory(@"C:\Users\Administrator\Desktop\bitbucket\d14web");
      SafeCall(
        () =>
        {
          var si = new ProcessStartInfo { FileName = @"C:\GIT\bin\git.exe", Arguments = "add -A" };
          var pr = Process.Start(si);
          pr.WaitForExit();
        });

      SafeCall(
        () =>
        {
          var si = new ProcessStartInfo { FileName = @"C:\GIT\bin\git.exe", Arguments = $"commit -m \"{DateTime.Now:yyyy-MM-dd}\"" };
          var pr = Process.Start(si);
          pr.WaitForExit();
        });

      SafeCall(
      () =>
      {
        var si = new ProcessStartInfo { FileName = @"C:\GIT\bin\git.exe", Arguments = "push origin master" };
        var pr = Process.Start(si);
        pr.WaitForExit();
      });
    }

    private static void SafeCall(Action action)
    {
      try
      {
        action();
      }
      catch { }
    }
  }
}
