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

namespace d14tive.WindowsClient.Controls.Abstract
{
  public partial class AbstractUserControl : UserControl
  {
    public AbstractUserControl()
    {
      try
      {
        ThemeResolutionService.ApplicationThemeName = "Material";
      }
      catch { }
      InitializeComponent();
    }
  }
}
