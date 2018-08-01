using System;
using System.Collections.Generic;
using System.Linq;
using CorpusExplorer.Sdk.Model.Interface;

namespace d14tive.TweetsToCsv
{
  public static class OriginalTweetFilter
  {
    public static List<Guid> GetOriginalTweets(IHydra hydra)
    {
      var meta = hydra.DocumentMetadata.ToDictionary(x => x.Key, x => x.Value);
      var guids = new List<Guid>();
      foreach (var x in meta)
      {
        if (!x.Value.ContainsKey("Referenz (Id)"))
          continue;
        if ((ulong) x.Value["Referenz (Id)"] > 0)
          continue;
        if (!x.Value.ContainsKey("Externe-URL (|-separiert)"))
          continue;
        if (!string.IsNullOrWhiteSpace(x.Value["Externe-URL (|-separiert)"]?.ToString()))
          continue;

        guids.Add(x.Key);
      }

      return guids;
    }
  }
}