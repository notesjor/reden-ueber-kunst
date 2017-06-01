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
      this.txt_content = new Telerik.WinControls.UI.RadLabel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.txt_statistics = new Telerik.WinControls.UI.RadLabel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txt_userAccountname = new Telerik.WinControls.UI.RadLabel();
      this.txt_userDisplayname = new Telerik.WinControls.UI.RadLabel();
      ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
      this.radPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txt_content)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txt_statistics)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txt_userAccountname)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txt_userDisplayname)).BeginInit();
      this.SuspendLayout();
      // 
      // radPanel1
      // 
      this.radPanel1.Controls.Add(this.txt_content);
      this.radPanel1.Controls.Add(this.panel1);
      this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radPanel1.Location = new System.Drawing.Point(5, 5);
      this.radPanel1.Name = "radPanel1";
      this.radPanel1.Size = new System.Drawing.Size(790, 190);
      this.radPanel1.TabIndex = 0;
      // 
      // txt_content
      // 
      this.txt_content.AutoSize = false;
      this.txt_content.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txt_content.Font = new System.Drawing.Font("Arial", 16F);
      this.txt_content.Location = new System.Drawing.Point(0, 48);
      this.txt_content.Name = "txt_content";
      this.txt_content.Padding = new System.Windows.Forms.Padding(5);
      this.txt_content.Size = new System.Drawing.Size(790, 142);
      this.txt_content.TabIndex = 1;
      this.txt_content.Text = "radLabel1";
      this.txt_content.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Controls.Add(this.panel2);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(790, 48);
      this.panel1.TabIndex = 0;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.txt_statistics);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel3.Location = new System.Drawing.Point(440, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(350, 48);
      this.panel3.TabIndex = 2;
      // 
      // txt_statistics
      // 
      this.txt_statistics.AutoSize = false;
      this.txt_statistics.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txt_statistics.Font = new System.Drawing.Font("Arial", 12F);
      this.txt_statistics.ForeColor = System.Drawing.Color.Black;
      this.txt_statistics.Location = new System.Drawing.Point(0, 0);
      this.txt_statistics.Name = "txt_statistics";
      this.txt_statistics.Size = new System.Drawing.Size(350, 48);
      this.txt_statistics.TabIndex = 1;
      this.txt_statistics.Text = "radLabel3";
      this.txt_statistics.TextAlignment = System.Drawing.ContentAlignment.TopRight;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.txt_userAccountname);
      this.panel2.Controls.Add(this.txt_userDisplayname);
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
      // txt_userDisplayname
      // 
      this.txt_userDisplayname.Dock = System.Windows.Forms.DockStyle.Top;
      this.txt_userDisplayname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
      this.txt_userDisplayname.ForeColor = System.Drawing.Color.Black;
      this.txt_userDisplayname.Location = new System.Drawing.Point(0, 0);
      this.txt_userDisplayname.Name = "txt_userDisplayname";
      this.txt_userDisplayname.Size = new System.Drawing.Size(350, 22);
      this.txt_userDisplayname.TabIndex = 0;
      this.txt_userDisplayname.Text = "radLabel1";
      this.txt_userDisplayname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // TweetControl
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.radPanel1);
      this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "TweetControl";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.Size = new System.Drawing.Size(800, 200);
      ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
      this.radPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txt_content)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txt_statistics)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txt_userAccountname)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txt_userDisplayname)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Telerik.WinControls.UI.RadPanel radPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel3;
    private Telerik.WinControls.UI.RadLabel txt_statistics;
    private System.Windows.Forms.Panel panel2;
    private Telerik.WinControls.UI.RadLabel txt_userAccountname;
    private Telerik.WinControls.UI.RadLabel txt_userDisplayname;
    private Telerik.WinControls.UI.RadLabel txt_content;
  }
}
