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

      _random = new Random(DateTime.Today.Year + DateTime.Today.Month + DateTime.Today.Day);
      _appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

      LoadPagesApp();
      LoadPagesWeb();
      LoadPagesPic();

      timer_pages_Tick(null, null);
      timer_pages.Start();
      ResumeLayout(false);
    }

    private void LoadPagesApp()
    {

    }

    private void LoadPagesWeb()
    {
      var htmls = Directory.GetFiles(_appDir, "*.html");
      foreach (var html in htmls)
      {
        AddPage(new PageWeb { Url = html });
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
          AddPage(new PageImg { Images = images });
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

        ((AbstractPage)_pages[next].Controls[0]).ShowPage();
        radPageView1.SelectedPage = _pages[next];
        _pages.RemoveAt(next);
      }
      catch (Exception ex)
      {
        // ignore
      }
    }
  }
}