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
      this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
      this.SuspendLayout();
      // 
      // AbstractPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Name = "AbstractPage";
      this.Size = new System.Drawing.Size(800, 600);
      this.ResumeLayout(false);

    }

    #endregion

    private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
  }
}
