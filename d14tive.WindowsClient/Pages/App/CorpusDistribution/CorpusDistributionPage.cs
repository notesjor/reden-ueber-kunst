using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using d14tive.WindowsClient.Controls.HeatMap;
using d14tive.WindowsClient.Pages.Abstract;

namespace d14tive.WindowsClient.Pages.App.CorpusDistribution
{
  public partial class CorpusDistributionPage : AbstractPage
  {
    private int _timeout = 30000;
    private HeatMapView _heatmap;
    private Dictionary<int, DataTable> _dic;
    private bool _init;
    private int _min;

    public CorpusDistributionPage()
    {
      InitializeComponent();

      SuspendLayout();

      _heatmap = new HeatMapView
      {
        HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch,
        VerticalAlignment = System.Windows.VerticalAlignment.Stretch
      };
      elementHost1.Child = _heatmap;

      Timer = new[] {_timeout};

      ResumeLayout(false);
    }

    public override void ShowPage(Size size)
    {
      lbl_info.Text = "";
      InitPage();
      radTrackBar1.Value = radTrackBar1.Minimum;
      timer1.Start();
    }

    private void InitPage()
    {
      if (_init)
        return;

      var lines = File.ReadAllLines("Influence.csv", Encoding.UTF8);

      var years = new List<int>();
      var split = lines[0].Split('\t');
      for (var i = 1; i < split.Length; i++)
        years.Add(int.Parse(split[i]));

      var temp = years.ToDictionary(year => year, year => new Dictionary<string, int>());
      for (var i = 1; i < lines.Length; i++)
      {
        split = lines[i].Split(new[] {"\t"}, StringSplitOptions.None);
        var name = split[0];

        for (var j = 1; j < split.Length; j++)
        {
          int val;
          if (string.IsNullOrEmpty(split[j]))
            val = (int) 0.0;
          else
            val = (int) (double.Parse(split[j]));
          temp[years[j - 1]].Add(name, val);
        }
      }

      _dic = new Dictionary<int, DataTable>();
      foreach (var year in years)
      {
        var dt = new DataTable();
        dt.Columns.Add("Autor", typeof(string));
        dt.Columns.Add("Token", typeof(int));
        dt.BeginLoadData();

        var dic = temp[year].OrderByDescending(x => x.Value).Take(100);
        foreach (var x in dic)
        {
          dt.Rows.Add(x.Key, x.Value);
        }

        dt.EndLoadData();
        _dic.Add(year, dt);
      }

      _min = _dic.Select(x => x.Key).Concat(new[] {3000}).Min();
      var max = _dic.Select(x => x.Key).Concat(new[] {1900}).Max();

      radTrackBar1.Maximum = max;
      radTrackBar1.Minimum = _min;
      radTrackBar1.Value = radTrackBar1.Minimum;
      timer1.Interval = _timeout / (max - _min + 2);

      _init = true;
    }

    private void radTrackBar1_ValueChanged(object sender, EventArgs e)
    {
      if (!_init)
        return;
      lbl_info.Text = $"Einfluss einzelner Autoren im Pressekorpus (aggregiert {_min} - {(int) radTrackBar1.Value})";
      _heatmap.DataSource = _dic[(int)radTrackBar1.Value];
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (radTrackBar1.Value < radTrackBar1.Maximum)
        radTrackBar1.Value++;
      else
        timer1.Stop();
    }
  }
}
