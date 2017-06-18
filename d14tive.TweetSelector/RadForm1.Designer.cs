namespace d14tive.TweetSelector
{
  partial class RadForm1
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
      Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
      this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.btn_open = new Telerik.WinControls.UI.RadButton();
      this.btn_save = new Telerik.WinControls.UI.RadButton();
      this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
      this.flowLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.btn_open)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.btn_open);
      this.flowLayoutPanel1.Controls.Add(this.btn_save);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(118, 416);
      this.flowLayoutPanel1.TabIndex = 0;
      // 
      // btn_open
      // 
      this.btn_open.Image = global::d14tive.TweetSelector.Properties.Resources.folder_open;
      this.btn_open.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
      this.btn_open.Location = new System.Drawing.Point(3, 3);
      this.btn_open.Name = "btn_open";
      this.btn_open.Size = new System.Drawing.Size(110, 110);
      this.btn_open.TabIndex = 0;
      this.btn_open.Text = "Öffnen";
      this.btn_open.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
      // 
      // btn_save
      // 
      this.btn_save.Image = global::d14tive.TweetSelector.Properties.Resources.save;
      this.btn_save.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
      this.btn_save.Location = new System.Drawing.Point(3, 119);
      this.btn_save.Name = "btn_save";
      this.btn_save.Size = new System.Drawing.Size(110, 110);
      this.btn_save.TabIndex = 1;
      this.btn_save.Text = "Speichern";
      this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
      // 
      // radGridView1
      // 
      this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radGridView1.Location = new System.Drawing.Point(118, 0);
      // 
      // 
      // 
      this.radGridView1.MasterTemplate.AllowAddNewRow = false;
      this.radGridView1.MasterTemplate.AllowDeleteRow = false;
      this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
      this.radGridView1.Name = "radGridView1";
      this.radGridView1.Size = new System.Drawing.Size(714, 416);
      this.radGridView1.TabIndex = 1;
      this.radGridView1.Text = "radGridView1";
      // 
      // RadForm1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(832, 416);
      this.Controls.Add(this.radGridView1);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Name = "RadForm1";
      // 
      // 
      // 
      this.RootElement.ApplyShapeToControl = true;
      this.Text = "TweetSelector";
      this.ThemeName = "Material";
      this.flowLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.btn_open)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private Telerik.WinControls.UI.RadButton btn_open;
    private Telerik.WinControls.UI.RadButton btn_save;
    private Telerik.WinControls.UI.RadGridView radGridView1;
  }
}