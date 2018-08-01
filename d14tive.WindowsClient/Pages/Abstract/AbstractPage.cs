using System.Drawing;
using d14tive.WindowsClient.Controls.Abstract;

namespace d14tive.WindowsClient.Pages.Abstract
{
  public partial class AbstractPage : AbstractUserControl
  {
    public AbstractPage()
    {
      InitializeComponent();
    }

    public int Timer { get; set; } = MyConfiguration.PageTimeout;

    public virtual void HidePage()
    {
      // ignore
    }

    public virtual void ShowPage(Size size)
    {
      // ignore
    }
  }
}