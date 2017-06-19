using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace CorpusExplorer.Tool4.TwitterDumpDocumentaService
{
  [RunInstaller(true)]
  public class MyServiceInstaller : Installer
  {
    public MyServiceInstaller()
    {
      var mThisService = new ServiceInstaller();
      var mThisServiceProcess = new ServiceProcessInstaller {Account = ServiceAccount.NetworkService};

      mThisService.ServiceName = "CorpusExplorer - d14";
      mThisService.StartType = ServiceStartMode.Automatic;

      Installers.Add(mThisService);
      Installers.Add(mThisServiceProcess);
    }
  }
}