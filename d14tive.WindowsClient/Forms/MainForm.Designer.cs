﻿namespace d14tive.WindowsClient.Forms
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
      ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // radPageView1
      // 
      this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radPageView1.Location = new System.Drawing.Point(0, 0);
      this.radPageView1.Name = "radPageView1";
      this.radPageView1.Size = new System.Drawing.Size(800, 540);
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
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Controls.Add(this.radLabel1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 540);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 60);
      this.panel1.TabIndex = 1;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.radLabel2);
      this.panel2.Controls.Add(this.pictureBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(311, 60);
      this.panel2.TabIndex = 2;
      // 
      // radLabel2
      // 
      this.radLabel2.AutoSize = false;
      this.radLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
      this.radLabel2.Location = new System.Drawing.Point(0, 37);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new System.Drawing.Size(311, 23);
      this.radLabel2.TabIndex = 2;
      this.radLabel2.Text = "<html><span style=\"font-size: 12pt\">Institut für Germanistik</span></html>";
      this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.pictureBox1.Image = global::d14tive.WindowsClient.Properties.Resources.Logo_Universitaet_607x120;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(311, 37);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // radLabel1
      // 
      this.radLabel1.AutoSize = false;
      this.radLabel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
      this.radLabel1.Location = new System.Drawing.Point(396, 0);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 64, 0);
      this.radLabel1.Size = new System.Drawing.Size(404, 60);
      this.radLabel1.TabIndex = 1;
      this.radLabel1.Text = "<html><span style=\"font-size: 12pt\">Projekt „Reden über Kunst - d14\"</span><br />" +
    "<strong><span style=\"font-size: 18pt\">www.reden-ueber-kunst.de</span></strong></" +
    "html>";
      this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 600);
      this.Controls.Add(this.radPageView1);
      this.Controls.Add(this.panel1);
      this.Name = "MainForm";
      // 
      // 
      // 
      this.RootElement.ApplyShapeToControl = true;
      this.Text = "MainForm";
      ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Telerik.WinControls.UI.RadPageView radPageView1;
    private System.Windows.Forms.Timer timer_pages;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private Telerik.WinControls.UI.RadLabel radLabel1;
    private System.Windows.Forms.Panel panel2;
    private Telerik.WinControls.UI.RadLabel radLabel2;
  }
}