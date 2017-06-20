using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d14tive.WindowsClient.Pages.App.CurrentTweets.Model
{
  public class TweetGroup
  {
    public string Topic { get; set; }
    public List<TweetEntry> Entries { get; set; } = new List<TweetEntry>();
  }
}
