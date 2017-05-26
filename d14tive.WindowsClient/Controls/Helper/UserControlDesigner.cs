using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace d14tive.WindowsClient.Controls.Helper
{
  public class UserControlDesigner : ParentControlDesigner
  {
    public override void Initialize(System.ComponentModel.IComponent component)
    {
      base.Initialize(component);

      if (Control is CenterControl)
      {
        EnableDesignMode(((CenterControl)Control).DropZone, "DropZone");
      }
    }
  }
}
