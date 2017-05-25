﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace d14tive.WindowsClient.Pages.Abstract
{
  public partial class AbstractPage : UserControl
  {
    public AbstractPage()
    {
      try
      {
        ThemeResolutionService.ApplicationThemeName = "Material";
      }
      catch { }
      InitializeComponent();
    }

    public virtual void ShowPage()
    {
      // ignore
    }

    public virtual void HidePage()
    {
      // ignore
    }
  }
}