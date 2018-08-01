using System.Windows.Forms;
using Telerik.WinControls;

namespace d14tive.WindowsClient.Controls.Abstract
{
  public partial class AbstractUserControl : UserControl
  {
    public AbstractUserControl()
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