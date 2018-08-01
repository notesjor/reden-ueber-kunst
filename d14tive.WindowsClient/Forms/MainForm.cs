using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using CorpusExplorer.Sdk.Ecosystem.Model;
using d14tive.WindowsClient.Forms.Abstract;
using d14tive.WindowsClient.Pages.Abstract;
using d14tive.WindowsClient.Pages.App.CurrentTweets;
using d14tive.WindowsClient.Pages.Img;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace d14tive.WindowsClient.Forms
{
  public partial class MainForm : AbstractFillForm
  {
    private readonly string _appDir;
    private RadPageViewPage _defaultPage;
    private readonly List<RadPageViewPage> _pages = new List<RadPageViewPage>();
    private readonly Random _random;
    private bool _useDefaultPage;

    public MainForm()
    {
      InitializeComponent();

      SuspendLayout();

      #region Fix PageView

      radPageView1.GetChildAt(0).GetChildAt(0).Visibility = ElementVisibility.Collapsed;
      radPageView1.GetChildAt(0).GetChildAt(1).Padding = new Padding(5);
      radPageView1.GetChildAt(0).GetChildAt(1).BorderThickness = new Padding(0);
      ((RadPageViewContentAreaElement) radPageView1.GetChildAt(0).GetChildAt(1)).BorderWidth = 0;

      #endregion

      timer_pages.Interval = MyConfiguration.PageTimeout;

      _random = MyConfiguration.Random;
      _appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      ResumeLayout(false);

      Load += MainForm_Load;
    }

    private void AddPage(AbstractPage page, bool defaultPage = false)
    {
      page.SuspendLayout();

      page.Size = radPageView1.Size;
      page.Location = new Point(0, 0);
      page.Dock = DockStyle.Fill;

      var master = new RadPageViewPage();
      master.Controls.Add(page);

      radPageView1.Pages.Add(master);
      if (defaultPage)
        _defaultPage = master;

      page.ResumeLayout(false);
    }

    private string GetLabel(string path)
    {
      return File.Exists(path) ? File.ReadAllText(path, Configuration.Encoding) : string.Empty;
    }

    private int GetTimer(string path)
    {
      if (!File.Exists(path))
        return MyConfiguration.PageTimeout;

      try
      {
        return int.Parse(File.ReadAllLines(path).First()) * 1000;
      }
      catch
      {
        return MyConfiguration.PageTimeout;
      }
    }

    private void LoadPagesApp()
    {
      if (File.Exists(@"tweets.txt"))
        AddPage(new CurrentTweetPage(), true);
    }

    private void LoadPagesImg()
    {
      var imgDir = Path.Combine(_appDir, "img");
      if (!Directory.Exists(imgDir))
        return;

      var dirs = Directory.GetDirectories(imgDir);
      foreach (var dir in dirs)
      {
        var images = Directory.GetFiles(dir, "*.png").OrderBy(x => x).Select(Image.FromFile).ToArray();

        if (images.Length > 0)
          AddPage(new PageImg(GetLabel(Path.Combine(dir, "_.label")))
          {
            Images = images,
            Timer = GetTimer(Path.Combine(dir, "_.timer"))
          });
      }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      LoadPagesApp();
      LoadPagesImg();

      timer_pages_Tick(null, null);
      timer_pages.Start();
    }

    private void SetPage(RadPageViewPage page)
    {
      var aPage = page.Controls[0] as AbstractPage;
      if (aPage == null)
        throw new Exception();

      if (radPageView1.SelectedPage != null && radPageView1.SelectedPage.Controls.Count == 1)
        ((AbstractPage) radPageView1.SelectedPage.Controls[0]).HidePage();

      aPage.ShowPage(radPageView1.Size);
      radPageView1.SelectedPage = page;

      timer_pages.Stop();
      // Wenn PageImg dann berechne den Timer aus Zeit-Einzelseite * Seiten
      // ReSharper disable once CanBeReplacedWithTryCastAndCheckForNull
      timer_pages.Interval = (aPage as PageImg)?.Images.Length * aPage.Timer ?? aPage.Timer;
      timer_pages.Start();
    }

    private void timer_pages_Tick(object sender, EventArgs e)
    {
      try
      {
        if (_pages.Count == 0)
        {
          _pages.AddRange(radPageView1.Pages);
          if (_defaultPage != null)
            _pages.Remove(_defaultPage);
        }

        _useDefaultPage = !_useDefaultPage;
        if (_defaultPage != null && _useDefaultPage)
        {
          SetPage(_defaultPage);
          return;
        }

        if (_pages.Count == 0)
          timer_pages.Stop();

        var next = _random.Next(0, _pages.Count);
        if (next < 0 || next >= _pages.Count)
          return;

        SetPage(_pages[next]);
        _pages.RemoveAt(next);
      }
      catch (Exception ex)
      {
        timer_pages.Start();
        // ignore
      }
    }
  }
}