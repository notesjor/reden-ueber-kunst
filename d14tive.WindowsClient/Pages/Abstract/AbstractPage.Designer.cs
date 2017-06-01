namespace d14tive.WindowsClient.Pages.Abstract
{
  partial class AbstractPage
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
      this.lbl_info = new Telerik.WinControls.UI.RadLabel();
      ((System.ComponentModel.ISupportInitialize)(this.lbl_info)).BeginInit();
      this.SuspendLayout();
      // 
      // lbl_info
      // 
      this.lbl_info.AutoSize = false;
      this.lbl_info.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lbl_info.Location = new System.Drawing.Point(0, 574);
      this.lbl_info.Name = "lbl_info";
      this.lbl_info.Size = new System.Drawing.Size(800, 26);
      this.lbl_info.TabIndex = 0;
      this.lbl_info.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // AbstractPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.lbl_info);
      this.Name = "AbstractPage";
      ((System.ComponentModel.ISupportInitialize)(this.lbl_info)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    protected Telerik.WinControls.UI.RadLabel lbl_info;
  }
}
