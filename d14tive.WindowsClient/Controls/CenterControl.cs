using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using d14tive.WindowsClient.Controls.Abstract;
using d14tive.WindowsClient.Controls.Helper;

namespace d14tive.WindowsClient.Controls
{
  [Designer(typeof(UserControlDesigner))]
  public partial class CenterControl : AbstractUserControl
  {
    public CenterControl()
    {
      InitializeComponent();
    }

    [Category("Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Panel DropZone => panel_dropZone;

    public void Adjust(Size size)
    {
      panel_left.BackColor = panel_right.BackColor = panel_bottom.BackColor = panel_up.BackColor = Color.White;

      var width = size.Width - 800;
      var height = size.Height - 600;

      if (width > 1)
      {
        panel_left.Width = panel_right.Width = width / 2;
      }
      if (height > 1)
      {
        panel_up.Height = height / 2;
        panel_bottom.Height = height / 2 - 10;
      }
    }
  }
}
