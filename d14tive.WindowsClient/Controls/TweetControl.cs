using System.Collections.Generic;
using d14tive.WindowsClient.Controls.Abstract;

namespace d14tive.WindowsClient.Controls
{
  public partial class TweetControl : AbstractUserControl
  {
    public TweetControl()
    {
      InitializeComponent();
    }

    public string UserDisplayname
    {
      set => txt_userDisplayname.Text = value;
      get => txt_userDisplayname.Text;
    }

    public string UserAccountname
    {
      set => txt_userAccountname.Text = value;
      get => txt_userAccountname.Text;
    }

    public IEnumerable<IEnumerable<string>> Content
    {
      set => wpfTagger1.Text = value;
    }

    public string Statistics
    {
      set => txt_statistics.Text = value;
      get => txt_statistics.Text;
    }

    /*
    public Image UserImage
    {
      set => img_user.Image = value;
      get => img_user.Image;
    }
    */
  }
}