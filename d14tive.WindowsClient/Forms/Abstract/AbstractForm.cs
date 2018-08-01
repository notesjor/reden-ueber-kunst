using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace d14tive.WindowsClient.Forms.Abstract
{
  public partial class AbstractForm : RadForm
  {
    public AbstractForm()
    {
      try
      {
        ThemeResolutionService.ApplicationThemeName = "Material";
      }
      catch
      {
      }

      InitializeComponent();
    }
  }
}