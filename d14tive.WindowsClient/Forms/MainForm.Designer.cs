namespace d14tive.WindowsClient.Forms
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
      this.timer_pages = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // radPageView1
      // 
      this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radPageView1.Location = new System.Drawing.Point(0, 0);
      this.radPageView1.Name = "radPageView1";
      this.radPageView1.Size = new System.Drawing.Size(800, 600);
      this.radPageView1.TabIndex = 0;
      this.radPageView1.Text = "radPageView1";
      ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).BorderWidth = 0F;
      ((Telerik.WinControls.UI.StripViewItemContainer)(this.radPageView1.GetChildAt(0).GetChildAt(0))).BorderWidth = 0F;
      ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BorderWidth = 0F;
      ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(2))).BorderWidth = 0F;
      ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(3))).BorderWidth = 0F;
      // 
      // timer_pages
      // 
      this.timer_pages.Interval = 16000;
      this.timer_pages.Tick += new System.EventHandler(this.timer_pages_Tick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 600);
      this.Controls.Add(this.radPageView1);
      this.Name = "MainForm";
      // 
      // 
      // 
      this.RootElement.ApplyShapeToControl = true;
      this.Text = "MainForm";
      ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Telerik.WinControls.UI.RadPageView radPageView1;
    private System.Windows.Forms.Timer timer_pages;
  }
}