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

    public string Content
    {
      set => txt_content.Text = value;
      get => txt_content.Text;
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