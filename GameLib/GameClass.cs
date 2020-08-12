using System;
using System.Threading;
using System.Threading.Tasks;

namespace GameLib
{
    public class GameClass
    {
        private static CancellationTokenSource tokenSource = new CancellationTokenSource();
        public static Task Timer(int time, int repeatCount)
        {
            CancellationToken token = tokenSource.Token;
            var task = new Task(() => 
            {
                for(int i = 0; i < repeatCount && !token.IsCancellationRequested; i++)
                {
                    Task.Delay(time * 1000).Wait();
                    if (!token.IsCancellationRequested) { Console.WriteLine($"Time Left: {repeatCount - i}"); }
                }
            });
            task.Start();
            return task;
        }
        public static void StopTask() 
        {
            tokenSource.Cancel();
        }
    }
}
