using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using d14tive.WindowsClient.Pages.Abstract;

namespace d14tive.WindowsClient.Pages.Img
{
  public partial class PageImg : AbstractPage
  {
    private int _index;

    public PageImg()
    {
      InitializeComponent();
    }

    public Image[] Images { get; set; }
    public string Label { get; set; } = "";

    public override void ShowPage(Size size)
    {
      _index = 0;        
      pictureBox1.Image = Images[_index];
      if (Images.Length == 1)
        return;

      timer_images.Interval = Timer;
      timer_images.Start();
    }

    public override void HidePage() { timer_images.Stop(); }

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
