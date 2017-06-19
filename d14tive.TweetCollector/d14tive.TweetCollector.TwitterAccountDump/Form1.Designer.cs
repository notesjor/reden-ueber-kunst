namespace CorpusExplorer.Tool4.TwitterAccountDump
{
  partial class Form1
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

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.link_appNew = new System.Windows.Forms.LinkLabel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.txt_auth_consumerKey = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txt_auth_consumerSecret = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.txt_auth_appName = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.txt_auth_ownderId = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.panel5 = new System.Windows.Forms.Panel();
      this.txt_auth_token = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.panel6 = new System.Windows.Forms.Panel();
      this.txt_auth_tokenSecret = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.btn_checkConnection = new System.Windows.Forms.Button();
      this.panel_if_connected = new System.Windows.Forms.Panel();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.btn_start = new System.Windows.Forms.Button();
      this.panel7 = new System.Windows.Forms.Panel();
      this.txt_account = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel6.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.panel_if_connected.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.panel7.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(784, 37);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Schritt 1 - Twitter Account anlegen...";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.panel6);
      this.groupBox2.Controls.Add(this.panel5);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.panel4);
      this.groupBox2.Controls.Add(this.panel2);
      this.groupBox2.Controls.Add(this.panel1);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.panel3);
      this.groupBox2.Controls.Add(this.link_appNew);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox2.Location = new System.Drawing.Point(0, 37);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(784, 227);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Schritt 2 - Twitter-API Key beantragen";
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(3, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(778, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Legen Sie einen Twitter-Account an. Es wird empfohlen, den Account ausschließlich" +
    " für diese Software zu nutzen.";
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Location = new System.Drawing.Point(3, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(778, 18);
      this.label2.TabIndex = 1;
      this.label2.Text = "Beantragen Sie einen Twitter-API KEY über die folgende URL und tragen Sie die Inf" +
    "ormationen wir gefordert ein:";
      // 
      // link_appNew
      // 
      this.link_appNew.Dock = System.Windows.Forms.DockStyle.Top;
      this.link_appNew.Location = new System.Drawing.Point(3, 34);
      this.link_appNew.Name = "link_appNew";
      this.link_appNew.Size = new System.Drawing.Size(778, 19);
      this.link_appNew.TabIndex = 2;
      this.link_appNew.TabStop = true;
      this.link_appNew.Text = "https://apps.twitter.com/app/new";
      this.link_appNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_appNew_LinkClicked);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txt_auth_consumerKey);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 92);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(778, 21);
      this.panel1.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.Dock = System.Windows.Forms.DockStyle.Left;
      this.label3.Location = new System.Drawing.Point(0, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(189, 21);
      this.label3.TabIndex = 0;
      this.label3.Text = "Consumer Key (API Key):";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txt_auth_consumerKey
      // 
      this.txt_auth_consumerKey.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txt_auth_consumerKey.Location = new System.Drawing.Point(189, 0);
      this.txt_auth_consumerKey.Name = "txt_auth_consumerKey";
      this.txt_auth_consumerKey.Size = new System.Drawing.Size(589, 20);
      this.txt_auth_consumerKey.TabIndex = 1;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.txt_auth_consumerSecret);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(3, 113);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(778, 21);
      this.panel2.TabIndex = 4;
      // 
      // txt_auth_consumerSecret
      // 
      this.txt_auth_consumerSecret.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txt_auth_consumerSecret.Location = new System.Drawing.Point(189, 0);
      this.txt_auth_consumerSecret.Name = "txt_auth_consumerSecret";
      this.txt_auth_consumerSecret.Size = new System.Drawing.Size(589, 20);
      this.txt_auth_consumerSecret.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.Dock = System.Windows.Forms.DockStyle.Left;
      this.label4.Location = new System.Drawing.Point(0, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(189, 21);
      this.label4.TabIndex = 0;
      this.label4.Text = "Consumer Secret (API Secret):";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label5
      // 
      this.label5.Dock = System.Windows.Forms.DockStyle.Top;
      this.label5.Location = new System.Drawing.Point(3, 74);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(778, 18);
      this.label5.TabIndex = 5;
      this.label5.Text = "Nach der Erstellung klicken Sie auf den Reiter \"Keys and Access Tokens\"";
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.txt_auth_appName);
      this.panel3.Controls.Add(this.label6);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(3, 53);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(778, 21);
      this.panel3.TabIndex = 6;
      // 
      // txt_auth_appName
      // 
      this.txt_auth_appName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txt_auth_appName.Location = new System.Drawing.Point(189, 0);
      this.txt_auth_appName.Name = "txt_auth_appName";
      this.txt_auth_appName.Size = new System.Drawing.Size(589, 20);
      this.txt_auth_appName.TabIndex = 1;
      // 
      // label6
      // 
      this.label6.Dock = System.Windows.Forms.DockStyle.Left;
      this.label6.Location = new System.Drawing.Point(0, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(189, 21);
      this.label6.TabIndex = 0;
      this.label6.Text = "Application Details > Name:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.txt_auth_ownderId);
      this.panel4.Controls.Add(this.label7);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel4.Location = new System.Drawing.Point(3, 134);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(778, 21);
      this.panel4.TabIndex = 7;
      // 
      // txt_auth_ownderId
      // 
      this.txt_auth_ownderId.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txt_auth_ownderId.Location = new System.Drawing.Point(189, 0);
      this.txt_auth_ownderId.Name = "txt_auth_ownderId";
      this.txt_auth_ownderId.Size = new System.Drawing.Size(589, 20);
      this.txt_auth_ownderId.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.Dock = System.Windows.Forms.DockStyle.Left;
      this.label7.Location = new System.Drawing.Point(0, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(189, 21);
      this.label7.TabIndex = 0;
      this.label7.Text = "Owner ID:";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label8
      // 
      this.label8.Dock = System.Windows.Forms.DockStyle.Top;
      this.label8.Location = new System.Drawing.Point(3, 155);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(778, 18);
      this.label8.TabIndex = 8;
      this.label8.Text = "Scrollen Sie zum Ende der Seite und klicken Sie auf \"Create my access token\"";
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.txt_auth_token);
      this.panel5.Controls.Add(this.label9);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel5.Location = new System.Drawing.Point(3, 173);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(778, 21);
      this.panel5.TabIndex = 9;
      // 
      // txt_auth_token
      // 
      this.txt_auth_token.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txt_auth_token.Location = new System.Drawing.Point(189, 0);
      this.txt_auth_token.Name = "txt_auth_token";
      this.txt_auth_token.Size = new System.Drawing.Size(589, 20);
      this.txt_auth_token.TabIndex = 1;
      // 
      // label9
      // 
      this.label9.Dock = System.Windows.Forms.DockStyle.Left;
      this.label9.Location = new System.Drawing.Point(0, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(189, 21);
      this.label9.TabIndex = 0;
      this.label9.Text = "Access Token:";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.txt_auth_tokenSecret);
      this.panel6.Controls.Add(this.label10);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel6.Location = new System.Drawing.Point(3, 194);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(778, 21);
      this.panel6.TabIndex = 10;
      // 
      // txt_auth_tokenSecret
      // 
      this.txt_auth_tokenSecret.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txt_auth_tokenSecret.Location = new System.Drawing.Point(189, 0);
      this.txt_auth_tokenSecret.Name = "txt_auth_tokenSecret";
      this.txt_auth_tokenSecret.Size = new System.Drawing.Size(589, 20);
      this.txt_auth_tokenSecret.TabIndex = 1;
      // 
      // label10
      // 
      this.label10.Dock = System.Windows.Forms.DockStyle.Left;
      this.label10.Location = new System.Drawing.Point(0, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(189, 21);
      this.label10.TabIndex = 0;
      this.label10.Text = "Access Token Secret:";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.btn_checkConnection);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox3.Location = new System.Drawing.Point(0, 264);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(784, 45);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Schritt 3 - Verbindung testen";
      // 
      // btn_checkConnection
      // 
      this.btn_checkConnection.Dock = System.Windows.Forms.DockStyle.Top;
      this.btn_checkConnection.Location = new System.Drawing.Point(3, 16);
      this.btn_checkConnection.Name = "btn_checkConnection";
      this.btn_checkConnection.Size = new System.Drawing.Size(778, 23);
      this.btn_checkConnection.TabIndex = 0;
      this.btn_checkConnection.Text = "...Klicken Sie hier, um die Verbindung zu testen...";
      this.btn_checkConnection.UseVisualStyleBackColor = true;
      this.btn_checkConnection.Click += new System.EventHandler(this.btn_checkConnection_Click);
      // 
      // panel_if_connected
      // 
      this.panel_if_connected.Controls.Add(this.groupBox4);
      this.panel_if_connected.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel_if_connected.Location = new System.Drawing.Point(0, 309);
      this.panel_if_connected.Name = "panel_if_connected";
      this.panel_if_connected.Size = new System.Drawing.Size(784, 47);
      this.panel_if_connected.TabIndex = 3;
      this.panel_if_connected.Visible = false;
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.panel7);
      this.groupBox4.Controls.Add(this.btn_start);
      this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox4.Location = new System.Drawing.Point(0, 0);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(784, 41);
      this.groupBox4.TabIndex = 0;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Schritt 4 - Account erfassen";
      // 
      // btn_start
      // 
      this.btn_start.Dock = System.Windows.Forms.DockStyle.Right;
      this.btn_start.Location = new System.Drawing.Point(706, 16);
      this.btn_start.Name = "btn_start";
      this.btn_start.Size = new System.Drawing.Size(75, 22);
      this.btn_start.TabIndex = 0;
      this.btn_start.Text = "Erfassen";
      this.btn_start.UseVisualStyleBackColor = true;
      this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.txt_account);
      this.panel7.Controls.Add(this.label11);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel7.Location = new System.Drawing.Point(3, 16);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(703, 21);
      this.panel7.TabIndex = 7;
      // 
      // txt_account
      // 
      this.txt_account.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txt_account.Location = new System.Drawing.Point(189, 0);
      this.txt_account.Name = "txt_account";
      this.txt_account.Size = new System.Drawing.Size(514, 20);
      this.txt_account.TabIndex = 1;
      // 
      // label11
      // 
      this.label11.Dock = System.Windows.Forms.DockStyle.Left;
      this.label11.Location = new System.Drawing.Point(0, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(189, 21);
      this.label11.TabIndex = 0;
      this.label11.Text = "@Accountname:";
      this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 356);
      this.Controls.Add(this.panel_if_connected);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.panel_if_connected.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.LinkLabel link_appNew;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txt_auth_consumerKey;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txt_auth_consumerSecret;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.TextBox txt_auth_tokenSecret;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.TextBox txt_auth_token;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.TextBox txt_auth_ownderId;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TextBox txt_auth_appName;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button btn_checkConnection;
    private System.Windows.Forms.Panel panel_if_connected;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.TextBox txt_account;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Button btn_start;
  }
}

