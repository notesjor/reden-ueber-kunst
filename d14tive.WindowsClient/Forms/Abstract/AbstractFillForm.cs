using System;
using System.Drawing;
using System.Windows.Forms;

namespace d14tive.WindowsClient.Forms.Abstract
{
  public partial class AbstractFillForm : AbstractForm
  {
    public AbstractFillForm()
    {
      InitializeComponent();

      SuspendLayout();

      Size = new Size(800, 600);
      FormBorderStyle = FormBorderStyle.None;
      StartPosition = FormStartPosition.CenterScreen;
      Load += AbstractFillForm_Load;

      ResumeLayout(false);
    }

    private void AbstractFillForm_Load(object sender, EventArgs e)
    {
      SuspendLayout();

      WindowState = FormWindowState.Maximized;

      ResumeLayout(false);
    }
  }
}