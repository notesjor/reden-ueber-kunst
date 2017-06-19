using System;
using System.Threading;
using System.Threading.Tasks;

namespace CorpusExplorer.Tool4.TwitterDump
{
  public static class TaskExtension
  {
    public static async Task<T> AddCancellationToken<T>(this Task<T> task, CancellationToken token)
    {
      var tcs = new TaskCompletionSource<bool>();
      using (token.Register(s => ((TaskCompletionSource<bool>) s).TrySetResult(true), tcs))
      {
        if (task != await Task.WhenAny(task, tcs.Task))
          throw new OperationCanceledException(token);
      }
      return await task;
    }
  }
}