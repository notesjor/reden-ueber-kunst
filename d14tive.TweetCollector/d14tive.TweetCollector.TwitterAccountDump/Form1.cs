using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToTwitter;
using Newtonsoft.Json;

namespace CorpusExplorer.Tool4.TwitterAccountDump
{
  public partial class Form1 : Form
  {
    private TwitterContext _context;

    public Form1()
    {
      InitializeComponent();
    }

    private ICredentialStore GetCredential()
    {
      return new InMemoryCredentialStore
      {
        ConsumerKey = txt_auth_consumerKey.Text,
        ConsumerSecret = txt_auth_consumerSecret.Text,
        OAuthToken = txt_auth_token.Text,
        OAuthTokenSecret = txt_auth_tokenSecret.Text,
        ScreenName = txt_auth_appName.Text,
        UserID = ulong.Parse(txt_auth_ownderId.Text)
      };
    }

    private void link_appNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("https://apps.twitter.com/app/new");
    }

    private void btn_checkConnection_Click(object sender, EventArgs e)
    {
      _context = new TwitterContext(new SingleUserAuthorizer { CredentialStore = GetCredential() });
      panel_if_connected.Visible = _context.User != null;
    }

    private void btn_start_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show(
            "Soll die Abfrage gestartet werden? Für die Zeit fer Abfrage verschindet das Hauptfenster.",
            "Abfrage starten?",
            MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      Hide();

      var tweets = (from tweet in _context.Status
                    where tweet.Type == StatusType.User
                          && tweet.ScreenName == txt_account.Text
                          && tweet.Count == 200
                    select tweet).ToList();

      ulong maxId = 0;
      if (tweets.Count > 0)
        maxId = ulong.Parse(tweets.Last().StatusID.ToString()) - 1;

      do
      {
        var limit = _context.RateLimitRemaining;
        if (limit == 0)
          break;

        var ntweets = (from tweet in _context.Status
                       where tweet.Type == StatusType.User
                             && tweet.ScreenName == txt_account.Text
                             && tweet.MaxID == maxId
                             && tweet.Count == 200
                       select tweet).ToArray();
        tweets.AddRange(ntweets);

        if (ntweets.Length > 0)
        {
          maxId = ulong.Parse(tweets.Last().StatusID.ToString()) - 1;
        }
        else
        {
          break;
        }
      } while (true);

      var dir = Path.Combine(
        Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
        txt_account.Text.Replace("@", ""));

      if (!Directory.Exists(dir))
        Directory.CreateDirectory(dir);

      foreach (var tweet in tweets)
      {
        File.WriteAllText(
          Path.Combine(dir, $"{tweet.CreatedAt:yyyy-MM-dd_HH-mm-ss}.json"),
          JsonConvert.SerializeObject(tweet));
      }

      Show();
    }
  }
}
