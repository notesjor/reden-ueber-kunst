﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using d14tive.WindowsClient.Forms.Abstract;
using d14tive.WindowsClient.Pages.Abstract;
using d14tive.WindowsClient.Pages.App.CurrentTweets;
using d14tive.WindowsClient.Pages.App.WordCloud;
using d14tive.WindowsClient.Pages.Img;
using d14tive.WindowsClient.Pages.Web;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace d14tive.WindowsClient.Forms
{
  public partial class MainForm : AbstractFillForm
  {
    private List<RadPageViewPage> _pages = new List<RadPageViewPage>();
    private Random _random;
    private string _appDir;

    public MainForm()
    {
      InitializeComponent();

      SuspendLayout();

      #region Fix PageView
      radPageView1.GetChildAt(0).GetChildAt(0).Visibility = ElementVisibility.Collapsed;
      radPageView1.GetChildAt(0).GetChildAt(1).Padding = new Padding(5);
      radPageView1.GetChildAt(0).GetChildAt(1).BorderThickness = new Padding(0);
      ((RadPageViewContentAreaElement)radPageView1.GetChildAt(0).GetChildAt(1)).BorderWidth = 0;
      #endregion

      timer_pages.Interval = MyConfiguration.PageTimeout;

      _random = MyConfiguration.Random;
      _appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      ResumeLayout(false);

      Load += MainForm_Load;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      LoadPagesApp();
      LoadPagesWeb();
      LoadPagesPic();

      timer_pages_Tick(null, null);
      timer_pages.Start();
    }

    private void LoadPagesApp()
    {
      if (File.Exists(@"wordcloud.page"))
        AddPage(new WordCloudPage(_appDir));
      if (File.Exists(@"tweets.cec6"))
      {
        AddPage(new CurrentTweetPage());
        AddPage(new CurrentTweetPage());
        AddPage(new CurrentTweetPage());
      }
    }

    private void LoadPagesWeb()
    {
      var htmls = Directory.GetFiles(_appDir, "*.html");

      foreach (var html in htmls)
      {
        AddPage(new PageWeb { Url = html, Timer = GetTimer(html + "_.timer") });
      }
    }

    private void LoadPagesPic()
    {
      var imgDir = Path.Combine(_appDir, "img");
      if (!Directory.Exists(imgDir))
        return;

      var dirs = Directory.GetDirectories(imgDir);
      foreach (var dir in dirs)
      {
        var images = Directory.GetFiles(dir, "*.png").OrderBy(x => x).Select(Image.FromFile).ToArray();

        if (images.Length > 0)
          AddPage(new PageImg { Images = images, Timer = GetTimer(Path.Combine(dir, "_.timer")), Label = GetLabel(Path.Combine(dir, "_.label")) });
      }
    }

    private string GetLabel(string path)
    {
      return File.Exists(path) ? File.ReadAllText(path) : string.Empty;
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

    private void AddPage(AbstractPage page)
    {
      page.SuspendLayout();

      page.Size = radPageView1.Size;
      page.Location = new Point(0, 0);
      page.Dock = DockStyle.Fill;

      var master = new RadPageViewPage();
      master.Controls.Add(page);

      radPageView1.Pages.Add(master);

      page.ResumeLayout(false);
    }

    private void timer_pages_Tick(object sender, EventArgs e)
    {
      try
      {
        if (_pages.Count == 0)
          _pages.AddRange(radPageView1.Pages);

        if (_pages.Count == 0)
          timer_pages.Stop();

        var next = _random.Next(0, _pages.Count);
        if (next < 0 || next >= _pages.Count)
          return;

        if (radPageView1.SelectedPage != null && radPageView1.SelectedPage.Controls.Count == 1)
          ((AbstractPage)_pages[next].Controls[0]).HidePage();

        var page = _pages[next].Controls[0] as AbstractPage;
        if (page == null)
          throw new Exception();

        page.ShowPage(radPageView1.Size);

        timer_pages.Stop();
        // Wenn PageImg dann berechne den Timer aus Zeit-Einzelseite * Seiten
        // ReSharper disable once CanBeReplacedWithTryCastAndCheckForNull
        timer_pages.Interval = (page as PageImg)?.Images.Length * page.Timer ?? page.Timer;
        timer_pages.Start();

        radPageView1.SelectedPage = _pages[next];
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
