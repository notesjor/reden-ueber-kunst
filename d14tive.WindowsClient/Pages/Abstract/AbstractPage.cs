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
using Telerik.WinControls;

namespace d14tive.WindowsClient.Pages.Abstract
{
  public partial class AbstractPage : AbstractUserControl
  {
    public AbstractPage()
    {
      InitializeComponent();
    }

    public virtual void ShowPage(Size size)
    {
      // ignore
    }

    public virtual void HidePage()
    {
      // ignore
    }

    public int[] Timer { get; set; } = null;
  }
}
