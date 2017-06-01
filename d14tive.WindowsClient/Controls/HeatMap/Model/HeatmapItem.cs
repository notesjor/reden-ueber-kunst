#region

using System.Collections.Generic;

#endregion

namespace d14tive.WindowsClient.Controls.HeatMap.Model
{
  public class HeatmapItem : IHeatmapItem
  {
    public HeatmapItem(string name, long size)
    {
      Name = name;
      Size = size;
    }

    public List<IHeatmapItem> Children { get { return null; } }

    public string Name { get; }
    public long Size { get; }
  }
}