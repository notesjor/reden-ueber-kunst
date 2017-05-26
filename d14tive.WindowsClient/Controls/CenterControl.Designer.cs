namespace d14tive.WindowsClient.Controls
{
  partial class CenterControl
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
      this.panel_up = new System.Windows.Forms.Panel();
      this.panel_bottom = new System.Windows.Forms.Panel();
      this.panel_right = new System.Windows.Forms.Panel();
      this.panel_left = new System.Windows.Forms.Panel();
      this.panel_dropZone = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // panel_up
      // 
      this.panel_up.BackColor = System.Drawing.Color.Black;
      this.panel_up.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel_up.Location = new System.Drawing.Point(0, 0);
      this.panel_up.Name = "panel_up";
      this.panel_up.Size = new System.Drawing.Size(800, 5);
      this.panel_up.TabIndex = 0;
      // 
      // panel_bottom
      // 
      this.panel_bottom.BackColor = System.Drawing.Color.Black;
      this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel_bottom.Location = new System.Drawing.Point(0, 595);
      this.panel_bottom.Name = "panel_bottom";
      this.panel_bottom.Size = new System.Drawing.Size(800, 5);
      this.panel_bottom.TabIndex = 1;
      // 
      // panel_right
      // 
      this.panel_right.BackColor = System.Drawing.Color.Black;
      this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel_right.Location = new System.Drawing.Point(795, 5);
      this.panel_right.Name = "panel_right";
      this.panel_right.Size = new System.Drawing.Size(5, 590);
      this.panel_right.TabIndex = 2;
      // 
      // panel_left
      // 
      this.panel_left.BackColor = System.Drawing.Color.Black;
      this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel_left.Location = new System.Drawing.Point(0, 5);
      this.panel_left.Name = "panel_left";
      this.panel_left.Size = new System.Drawing.Size(5, 590);
      this.panel_left.TabIndex = 3;
      // 
      // panel1
      // 
      this.panel_dropZone.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_dropZone.Location = new System.Drawing.Point(5, 5);
      this.panel_dropZone.Name = "panel_dropZone";
      this.panel_dropZone.Size = new System.Drawing.Size(790, 590);
      this.panel_dropZone.TabIndex = 4;
      // 
      // CenterControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.panel_dropZone);
      this.Controls.Add(this.panel_left);
      this.Controls.Add(this.panel_right);
      this.Controls.Add(this.panel_bottom);
      this.Controls.Add(this.panel_up);
      this.Name = "CenterControl";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel_up;
    private System.Windows.Forms.Panel panel_bottom;
    private System.Windows.Forms.Panel panel_right;
    private System.Windows.Forms.Panel panel_left;
    public System.Windows.Forms.Panel panel_dropZone;
  }
}
