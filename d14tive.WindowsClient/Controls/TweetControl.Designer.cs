namespace d14tive.WindowsClient.Controls
{
  partial class TweetControl
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
      this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
      this.wpfTagger1 = new d14tive.WindowsClient.Controls.Tagger.WpfTagger();
      this.main_panel = new System.Windows.Forms.Panel();
      this.main_panel.SuspendLayout();
      this.SuspendLayout();
      // 
      // elementHost1
      // 
      this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.elementHost1.Location = new System.Drawing.Point(10, 10);
      this.elementHost1.Name = "elementHost1";
      this.elementHost1.Size = new System.Drawing.Size(770, 70);
      this.elementHost1.TabIndex = 1;
      this.elementHost1.Text = "elementHost1";
      this.elementHost1.Child = this.wpfTagger1;
      // 
      // main_panel
      // 
      this.main_panel.Controls.Add(this.elementHost1);
      this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.main_panel.Location = new System.Drawing.Point(5, 5);
      this.main_panel.Name = "main_panel";
      this.main_panel.Padding = new System.Windows.Forms.Padding(10);
      this.main_panel.Size = new System.Drawing.Size(790, 90);
      this.main_panel.TabIndex = 1;
      // 
      // TweetControl
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.main_panel);
      this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "TweetControl";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.Size = new System.Drawing.Size(800, 100);
      this.main_panel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Integration.ElementHost elementHost1;
    private Tagger.WpfTagger wpfTagger1;
    private System.Windows.Forms.Panel main_panel;
  }
}
