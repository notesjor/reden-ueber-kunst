using d14tive.WindowsClient.Controls;

namespace d14tive.WindowsClient.Pages.App.CurrentTweets
{
  partial class CurrentTweetPage
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
      this.centerControl1 = new d14tive.WindowsClient.Controls.CenterControl();
      this.tweetControl5 = new d14tive.WindowsClient.Controls.TweetControl();
      this.tweetControl4 = new d14tive.WindowsClient.Controls.TweetControl();
      this.tweetControl3 = new d14tive.WindowsClient.Controls.TweetControl();
      this.tweetControl2 = new d14tive.WindowsClient.Controls.TweetControl();
      this.tweetControl1 = new d14tive.WindowsClient.Controls.TweetControl();
      ((System.ComponentModel.ISupportInitialize)(this.lbl_info)).BeginInit();
      this.centerControl1.DropZone.SuspendLayout();
      this.centerControl1.SuspendLayout();
      this.SuspendLayout();
      // 
      // centerControl1
      // 
      this.centerControl1.BackColor = System.Drawing.Color.White;
      this.centerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      // 
      // centerControl1.DropZone
      // 
      this.centerControl1.DropZone.BackColor = System.Drawing.Color.Black;
      this.centerControl1.DropZone.Controls.Add(this.tweetControl5);
      this.centerControl1.DropZone.Controls.Add(this.tweetControl4);
      this.centerControl1.DropZone.Controls.Add(this.tweetControl3);
      this.centerControl1.DropZone.Controls.Add(this.tweetControl2);
      this.centerControl1.DropZone.Controls.Add(this.tweetControl1);
      this.centerControl1.DropZone.Dock = System.Windows.Forms.DockStyle.Fill;
      this.centerControl1.DropZone.Location = new System.Drawing.Point(5, 5);
      this.centerControl1.DropZone.Name = "DropZone";
      this.centerControl1.DropZone.Size = new System.Drawing.Size(790, 564);
      this.centerControl1.DropZone.TabIndex = 4;
      this.centerControl1.ForeColor = System.Drawing.Color.Black;
      this.centerControl1.Location = new System.Drawing.Point(0, 0);
      this.centerControl1.Name = "centerControl1";
      this.centerControl1.Size = new System.Drawing.Size(800, 574);
      this.centerControl1.TabIndex = 0;
      // 
      // tweetControl5
      // 
      this.tweetControl5.BackColor = System.Drawing.Color.Black;
      this.tweetControl5.Dock = System.Windows.Forms.DockStyle.Top;
      this.tweetControl5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tweetControl5.ForeColor = System.Drawing.Color.White;
      this.tweetControl5.Location = new System.Drawing.Point(0, 444);
      this.tweetControl5.Name = "tweetControl5";
      this.tweetControl5.Padding = new System.Windows.Forms.Padding(5);
      this.tweetControl5.Size = new System.Drawing.Size(790, 111);
      this.tweetControl5.TabIndex = 4;
      // 
      // tweetControl4
      // 
      this.tweetControl4.BackColor = System.Drawing.Color.Black;
      this.tweetControl4.Dock = System.Windows.Forms.DockStyle.Top;
      this.tweetControl4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tweetControl4.ForeColor = System.Drawing.Color.White;
      this.tweetControl4.Location = new System.Drawing.Point(0, 333);
      this.tweetControl4.Name = "tweetControl4";
      this.tweetControl4.Padding = new System.Windows.Forms.Padding(5);
      this.tweetControl4.Size = new System.Drawing.Size(790, 111);
      this.tweetControl4.TabIndex = 3;
      // 
      // tweetControl3
      // 
      this.tweetControl3.BackColor = System.Drawing.Color.Black;
      this.tweetControl3.Dock = System.Windows.Forms.DockStyle.Top;
      this.tweetControl3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tweetControl3.ForeColor = System.Drawing.Color.White;
      this.tweetControl3.Location = new System.Drawing.Point(0, 222);
      this.tweetControl3.Name = "tweetControl3";
      this.tweetControl3.Padding = new System.Windows.Forms.Padding(5);
      this.tweetControl3.Size = new System.Drawing.Size(790, 111);
      this.tweetControl3.TabIndex = 2;
      // 
      // tweetControl2
      // 
      this.tweetControl2.BackColor = System.Drawing.Color.Black;
      this.tweetControl2.Dock = System.Windows.Forms.DockStyle.Top;
      this.tweetControl2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tweetControl2.ForeColor = System.Drawing.Color.White;
      this.tweetControl2.Location = new System.Drawing.Point(0, 111);
      this.tweetControl2.Name = "tweetControl2";
      this.tweetControl2.Padding = new System.Windows.Forms.Padding(5);
      this.tweetControl2.Size = new System.Drawing.Size(790, 111);
      this.tweetControl2.TabIndex = 1;
      // 
      // tweetControl1
      // 
      this.tweetControl1.BackColor = System.Drawing.Color.Black;
      this.tweetControl1.Dock = System.Windows.Forms.DockStyle.Top;
      this.tweetControl1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tweetControl1.ForeColor = System.Drawing.Color.White;
      this.tweetControl1.Location = new System.Drawing.Point(0, 0);
      this.tweetControl1.Name = "tweetControl1";
      this.tweetControl1.Padding = new System.Windows.Forms.Padding(5);
      this.tweetControl1.Size = new System.Drawing.Size(790, 111);
      this.tweetControl1.TabIndex = 0;
      // 
      // CurrentTweetPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.centerControl1);
      this.Name = "CurrentTweetPage";
      this.Controls.SetChildIndex(this.lbl_info, 0);
      this.Controls.SetChildIndex(this.centerControl1, 0);
      ((System.ComponentModel.ISupportInitialize)(this.lbl_info)).EndInit();
      this.centerControl1.DropZone.ResumeLayout(false);
      this.centerControl1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.CenterControl centerControl1;
    private TweetControl tweetControl3;
    private TweetControl tweetControl2;
    private TweetControl tweetControl1;
    private TweetControl tweetControl5;
    private TweetControl tweetControl4;
  }
}
