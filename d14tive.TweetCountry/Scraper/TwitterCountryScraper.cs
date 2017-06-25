#region

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using CorpusExplorer.Sdk.Extern.Json.Abstract;
using CorpusExplorer.Sdk.Extern.Json.TwitterStream.Model;
using CorpusExplorer.Sdk.Extern.Json.TwitterStream.Reader;
using CorpusExplorer.Sdk.Helper;
using CorpusExplorer.Sdk.Model.Extension;

// ReSharper disable All

#endregion

namespace CorpusExplorer.Sdk.Extern.Json.TwitterStream
{
  public class TwitterCountryScraper : AbstractGenericJsonFormatScraper<StreamMessage>
  {
    protected override AbstractGenericDataReader<StreamMessage> DataReader { get { return new TwitterDataReader(); } }

    public override string DisplayName { get { return "Twitter JSON Scraper"; } }

    private IEnumerable<Dictionary<string, object>> PostProcessingMerge(
      Dictionary<ulong, List<Dictionary<string, object>>> dic)
    {
      const string Label1 = "Retweet-Rate";
      const string Label2 = "Favorisierungs-Rate";

      var res = new List<Dictionary<string, object>>();

      foreach (var message in dic)
      {
        var act = message.Value.FirstOrDefault();

        // Wenn mehr als eine Nachricht vorliegt dann aktualisiere auf den höchsten Retweet/Favorisirungs-Wert
        if (message.Value.Count > 1)
        {
          foreach (var version in message.Value.Where(version => version.Get(Label1, 0) > act.Get(Label1, 0)))
          {
            act.Set(Label1, version.Get(Label1, 0));
            act.Set(Label2, version.Get(Label2, 0));
          }
        }

        res.Add(act);
      }

      return res;
    }

    protected override IEnumerable<Dictionary<string, object>> ScrapDocuments(IEnumerable<StreamMessage> model)
    {
      if (model == null)
        return null;

      var res = new List<Dictionary<string, object>>();

      foreach (var message in model)
      {
        var act = message;

        // Rekursives Durchlaufen des RetweetStatus
        while (act != null)
        {
          var scrap = StreamMessageToScrapDocument(act);
          if (scrap == null)
            break;
          res.Add(scrap);
          act = act.RetweetedStatus;
        }
      }

      return res;
    }

    // ReSharper disable FunctionComplexityOverflow
    private Dictionary<string, object> StreamMessageToScrapDocument(StreamMessage message)
    // ReSharper restore FunctionComplexityOverflow
    {
      try
      {
        return
          new Dictionary<string, object>
          {
            {"Geo", message.Coordinates == null ? "" : GeoCoordinatesHelper.Serialize(message.Coordinates.Coordinates)},
            {"Datum", DateTime.ParseExact(message.CreatedAt, "ddd MMM dd HH:mm:ss zzz yyyy", CultureInfo.InvariantCulture)},
            {"Text", message.Text},
            {"Ländercode", message.Place == null ? "" : message.Place.CountryCode.ToUpper()},
          };
      }
      catch
      {
        return null;
      }
    }
  }
}