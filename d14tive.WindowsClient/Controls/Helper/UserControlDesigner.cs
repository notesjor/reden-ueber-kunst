using System.ComponentModel;
using System.Windows.Forms.Design;

namespace d14tive.WindowsClient.Controls.Helper
{
  public class UserControlDesigner : ParentControlDesigner
  {
    public override void Initialize(IComponent component)
    {
      base.Initialize(component);

      if (Control is CenterControl) EnableDesignMode(((CenterControl) Control).DropZone, "DropZone");
    }
  }
}