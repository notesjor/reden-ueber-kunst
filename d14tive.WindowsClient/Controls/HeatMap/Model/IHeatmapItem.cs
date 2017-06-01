#region

using System.Collections.Generic;

#endregion

namespace d14tive.WindowsClient.Controls.HeatMap.Model
{
  public interface IHeatmapItem
  {
    List<IHeatmapItem> Children { get; }
    string Name { get; }
    long Size { get; }
  }
}