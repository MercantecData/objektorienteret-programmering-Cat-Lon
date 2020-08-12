using System;
using System.Threading.Tasks;

namespace GameLib
{
    public class GameClass
    {
        public static Task Timer(int time, int repeatCount)
        {
            var task = new Task(() => 
            {
                for(int i = 0; i < repeatCount; i++)
                {
                    Task.Delay(time * 1000).Wait();
                    Console.WriteLine($"Time Left: {repeatCount - i}");
                }
            });
            task.Start();
            return task;
        }
    }
}
