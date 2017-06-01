namespace d14tive.WindowsClient.Pages.Web
{
  partial class PageWeb
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
      this.webBrowserControl1 = new d14tive.WindowsClient.Controls.WebBrowserControl();
      ((System.ComponentModel.ISupportInitialize)(this.lbl_info)).BeginInit();
      this.SuspendLayout();
      // 
      // webBrowserControl1
      // 
      this.webBrowserControl1.BackColor = System.Drawing.Color.White;
      this.webBrowserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.webBrowserControl1.ForeColor = System.Drawing.Color.Black;
      this.webBrowserControl1.Location = new System.Drawing.Point(0, 0);
      this.webBrowserControl1.Name = "webBrowserControl1";
      this.webBrowserControl1.Size = new System.Drawing.Size(800, 574);
      this.webBrowserControl1.TabIndex = 0;
      // 
      // PageWeb
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.webBrowserControl1);
      this.Name = "PageWeb";
      this.Controls.SetChildIndex(this.lbl_info, 0);
      this.Controls.SetChildIndex(this.webBrowserControl1, 0);
      ((System.ComponentModel.ISupportInitialize)(this.lbl_info)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.WebBrowserControl webBrowserControl1;
  }
}
