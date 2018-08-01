using System;
using System.Drawing;
using d14tive.WindowsClient.Pages.Abstract;

namespace d14tive.WindowsClient.Pages.Img
{
  public partial class PageImg : AbstractPage
  {
    private int _index;

    public PageImg(string label)
    {
      InitializeComponent();
      lbl_info.Text = label;
    }

    public Image[] Images { get; set; }

    public override void HidePage()
    {
      timer_images.Stop();
    }

    public override void ShowPage(Size size)
    {
      _index = 0;
      pictureBox1.Image = Images[_index];
      if (Images.Length == 1)
        return;

      timer_images.Interval = Timer;
      timer_images.Start();
    }

    private void timer_images_Tick(object sender, EventArgs e)
    {
      _index++;
      if (_index >= Images.Length)
      {
        timer_images.Stop();
        return;
      }

      pictureBox1.Image = Images[_index];
    }
  }
}