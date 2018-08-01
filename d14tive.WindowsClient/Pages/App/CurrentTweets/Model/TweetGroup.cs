using System.Collections.Generic;

namespace d14tive.WindowsClient.Pages.App.CurrentTweets.Model
{
  public class TweetGroup
  {
    public List<TweetEntry> Entries { get; set; } = new List<TweetEntry>();
    public string Topic { get; set; }
  }
}