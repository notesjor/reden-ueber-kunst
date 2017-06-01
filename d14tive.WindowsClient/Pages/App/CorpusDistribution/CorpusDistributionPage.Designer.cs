namespace d14tive.WindowsClient.Pages.App.CorpusDistribution
{
  partial class CorpusDistributionPage
  {
    /// <summary> 
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary> 
    /// Erforderliche Methode für die Designerunterstützung. 
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.radTrackBar1 = new Telerik.WinControls.UI.RadTrackBar();
      this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.lbl_info)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // lbl_info
      // 
      this.lbl_info.Location = new System.Drawing.Point(0, 528);
      // 
      // radTrackBar1
      // 
      this.radTrackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.radTrackBar1.Location = new System.Drawing.Point(0, 554);
      this.radTrackBar1.Minimum = 1F;
      this.radTrackBar1.Name = "radTrackBar1";
      this.radTrackBar1.Size = new System.Drawing.Size(800, 46);
      this.radTrackBar1.TabIndex = 0;
      this.radTrackBar1.Text = "radTrackBar1";
      this.radTrackBar1.ThumbSize = new System.Drawing.Size(12, 12);
      this.radTrackBar1.Value = 19F;
      this.radTrackBar1.Visible = false;
      this.radTrackBar1.ValueChanged += new System.EventHandler(this.radTrackBar1_ValueChanged);
      // 
      // elementHost1
      // 
      this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.elementHost1.Location = new System.Drawing.Point(0, 0);
      this.elementHost1.Name = "elementHost1";
      this.elementHost1.Size = new System.Drawing.Size(800, 528);
      this.elementHost1.TabIndex = 1;
      this.elementHost1.Text = "elementHost1";
      this.elementHost1.Child = null;
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // CorpusDistributionPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.elementHost1);
      this.Controls.Add(this.radTrackBar1);
      this.Name = "CorpusDistributionPage";
      this.Controls.SetChildIndex(this.radTrackBar1, 0);
      this.Controls.SetChildIndex(this.lbl_info, 0);
      this.Controls.SetChildIndex(this.elementHost1, 0);
      ((System.ComponentModel.ISupportInitialize)(this.lbl_info)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.radTrackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Telerik.WinControls.UI.RadTrackBar radTrackBar1;
    private System.Windows.Forms.Integration.ElementHost elementHost1;
    private System.Windows.Forms.Timer timer1;
  }
}
