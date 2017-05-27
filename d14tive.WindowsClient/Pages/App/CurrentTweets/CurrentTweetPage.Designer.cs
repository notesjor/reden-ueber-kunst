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
      this.tweetControl3 = new d14tive.WindowsClient.Pages.App.CurrentTweets.TweetControl();
      this.tweetControl2 = new d14tive.WindowsClient.Pages.App.CurrentTweets.TweetControl();
      this.tweetControl1 = new d14tive.WindowsClient.Pages.App.CurrentTweets.TweetControl();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
      this.centerControl1.DropZone.Controls.Add(this.tweetControl3);
      this.centerControl1.DropZone.Controls.Add(this.tweetControl2);
      this.centerControl1.DropZone.Controls.Add(this.tweetControl1);
      this.centerControl1.DropZone.Dock = System.Windows.Forms.DockStyle.Fill;
      this.centerControl1.DropZone.Location = new System.Drawing.Point(5, 5);
      this.centerControl1.DropZone.Name = "DropZone";
      this.centerControl1.DropZone.Size = new System.Drawing.Size(790, 590);
      this.centerControl1.DropZone.TabIndex = 4;
      this.centerControl1.ForeColor = System.Drawing.Color.Black;
      this.centerControl1.Location = new System.Drawing.Point(0, 0);
      this.centerControl1.Name = "centerControl1";
      this.centerControl1.Size = new System.Drawing.Size(800, 600);
      this.centerControl1.TabIndex = 0;
      // 
      // tweetControl3
      // 
      this.tweetControl3.BackColor = System.Drawing.Color.White;
      this.tweetControl3.Dock = System.Windows.Forms.DockStyle.Top;
      this.tweetControl3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tweetControl3.ForeColor = System.Drawing.Color.Black;
      this.tweetControl3.Location = new System.Drawing.Point(0, 400);
      this.tweetControl3.Name = "tweetControl3";
      this.tweetControl3.Padding = new System.Windows.Forms.Padding(5);
      this.tweetControl3.Size = new System.Drawing.Size(790, 200);
      this.tweetControl3.TabIndex = 2;
      // 
      // tweetControl2
      // 
      this.tweetControl2.BackColor = System.Drawing.Color.White;
      this.tweetControl2.Dock = System.Windows.Forms.DockStyle.Top;
      this.tweetControl2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tweetControl2.ForeColor = System.Drawing.Color.Black;
      this.tweetControl2.Location = new System.Drawing.Point(0, 200);
      this.tweetControl2.Name = "tweetControl2";
      this.tweetControl2.Padding = new System.Windows.Forms.Padding(5);
      this.tweetControl2.Size = new System.Drawing.Size(790, 200);
      this.tweetControl2.TabIndex = 1;
      // 
      // tweetControl1
      // 
      this.tweetControl1.BackColor = System.Drawing.Color.White;
      this.tweetControl1.Dock = System.Windows.Forms.DockStyle.Top;
      this.tweetControl1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tweetControl1.ForeColor = System.Drawing.Color.Black;
      this.tweetControl1.Location = new System.Drawing.Point(0, 0);
      this.tweetControl1.Name = "tweetControl1";
      this.tweetControl1.Padding = new System.Windows.Forms.Padding(5);
      this.tweetControl1.Size = new System.Drawing.Size(790, 200);
      this.tweetControl1.TabIndex = 0;
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      // 
      // CurrentTweetPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.centerControl1);
      this.Name = "CurrentTweetPage";
      this.centerControl1.DropZone.ResumeLayout(false);
      this.centerControl1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Controls.CenterControl centerControl1;
    private TweetControl tweetControl3;
    private TweetControl tweetControl2;
    private TweetControl tweetControl1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
  }
}
