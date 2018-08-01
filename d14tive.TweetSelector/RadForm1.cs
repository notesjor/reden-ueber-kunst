using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CorpusExplorer.Core.Exporter;
using CorpusExplorer.Sdk.Helper;
using CorpusExplorer.Sdk.Model.Adapter.Corpus;
using CorpusExplorer.Sdk.Model.Extension;
using d14tive.TweetsToCsv;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace d14tive.TweetSelector
{
  public partial class RadForm1 : RadForm
  {
    private CorpusAdapterWriteDirect _corpus;
    private readonly string _filter = "CEC6-Korpus (*.cec6)|*.cec6";

    public RadForm1()
    {
      try
      {
        ThemeResolutionService.ApplicationThemeName = "Material";
      }
      catch
      {
      }

      InitializeComponent();
    }

    private void btn_open_Click(object sender, EventArgs e)
    {
      var ofd = new OpenFileDialog {Filter = _filter, CheckFileExists = true};
      if (ofd.ShowDialog() != DialogResult.OK)
        return;

      _corpus = CorpusAdapterWriteDirect.Create(ofd.FileName);
      CorpusToGrid();
    }

    private void btn_save_Click(object sender, EventArgs e)
    {
      var list = (from row in radGridView1.Rows
        where (bool) row.Cells["?"].Value
        select Guid.Parse((string) row.Cells["GUID"].Value)).ToList();
      if (list.Count == 0)
        return;

      var selection = _corpus.ToSelection().Create(list, "output");
      var exporter = new ExporterCec6();
      exporter.Export(selection, @"tweets.cec6");

      Close();
    }

    private void CorpusToGrid()
    {
      var selection = _corpus.ToSelection().Create(OriginalTweetFilter.GetOriginalTweets(_corpus), "Original");
      var meta = selection.GetDocumentMetadataPrototypeOnlyProperties().ToArray();

      var dt = new DataTable();
      dt.Columns.Add("?", typeof(bool));
      dt.Columns.Add("Text", typeof(string));
      foreach (var m in meta)
        dt.Columns.Add(m, typeof(string));

      dt.BeginLoadData();

      foreach (var dsel in selection.DocumentGuids)
      {
        var values = new List<object>
        {
          false,
          _corpus.GetReadableDocument(dsel, "Wort").ReduceDocumentToText()
        };

        var dmeta = _corpus.GetDocumentMetadata(dsel);
        foreach (var m in meta)
          if (dmeta.ContainsKey(m))
            values.Add(dmeta[m] == null ? null : dmeta[m].ToString());
          else
            values.Add(null);

        dt.Rows.Add(values.ToArray());
      }

      dt.EndLoadData();
      radGridView1.DataSource = dt;
      foreach (var column in radGridView1.Columns)
        if (column.Name != "?")
          column.ReadOnly = true;

      radGridView1.BestFitColumns(BestFitColumnMode.AllCells);
    }
  }
}