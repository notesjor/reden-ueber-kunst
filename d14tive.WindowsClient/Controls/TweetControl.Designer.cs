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
      this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
      this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
      this.wpfTagger1 = new d14tive.WindowsClient.Controls.Tagger.WpfTagger();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txt_userAccountname = new Telerik.WinControls.UI.RadLabel();
      this.txt_username = new Telerik.WinControls.UI.RadLabel();
      ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
      this.radPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txt_userAccountname)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txt_username)).BeginInit();
      this.SuspendLayout();
      // 
      // radPanel1
      // 
      this.radPanel1.Controls.Add(this.elementHost1);
      this.radPanel1.Controls.Add(this.panel1);
      this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radPanel1.Location = new System.Drawing.Point(5, 5);
      this.radPanel1.Name = "radPanel1";
      this.radPanel1.Size = new System.Drawing.Size(790, 90);
      this.radPanel1.TabIndex = 0;
      // 
      // elementHost1
      // 
      this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.elementHost1.Location = new System.Drawing.Point(0, 48);
      this.elementHost1.Name = "elementHost1";
      this.elementHost1.Size = new System.Drawing.Size(790, 42);
      this.elementHost1.TabIndex = 1;
      this.elementHost1.Text = "elementHost1";
      this.elementHost1.Child = this.wpfTagger1;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(790, 48);
      this.panel1.TabIndex = 0;
      this.panel1.Visible = false;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.txt_userAccountname);
      this.panel2.Controls.Add(this.txt_username);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(350, 48);
      this.panel2.TabIndex = 1;
      // 
      // txt_userAccountname
      // 
      this.txt_userAccountname.Dock = System.Windows.Forms.DockStyle.Top;
      this.txt_userAccountname.Font = new System.Drawing.Font("Arial", 10.5F);
      this.txt_userAccountname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
      this.txt_userAccountname.Location = new System.Drawing.Point(0, 22);
      this.txt_userAccountname.Name = "txt_userAccountname";
      this.txt_userAccountname.Size = new System.Drawing.Size(350, 19);
      this.txt_userAccountname.TabIndex = 1;
      this.txt_userAccountname.Text = "radLabel2";
      this.txt_userAccountname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // txt_username
      // 
      this.txt_username.Dock = System.Windows.Forms.DockStyle.Top;
      this.txt_username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
      this.txt_username.ForeColor = System.Drawing.Color.Black;
      this.txt_username.Location = new System.Drawing.Point(0, 0);
      this.txt_username.Name = "txt_username";
      this.txt_username.Size = new System.Drawing.Size(350, 22);
      this.txt_username.TabIndex = 0;
      this.txt_username.Text = "radLabel1";
      this.txt_username.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // TweetControl
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.radPanel1);
      this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "TweetControl";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.Size = new System.Drawing.Size(800, 100);
      ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
      this.radPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txt_userAccountname)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txt_username)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Telerik.WinControls.UI.RadPanel radPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private Telerik.WinControls.UI.RadLabel txt_userAccountname;
    private Telerik.WinControls.UI.RadLabel txt_username;
    private System.Windows.Forms.Integration.ElementHost elementHost1;
    private Tagger.WpfTagger wpfTagger1;
  }
}
