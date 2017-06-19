using System;

namespace d14tive.WindowsClient
{
  public static class MyConfiguration
  {
    public static int PageTimeout { get; } = 16000;
    public static Random Random { get; set; } = new Random(DateTime.Now.Millisecond * DateTime.Now.Second);
  }
}
