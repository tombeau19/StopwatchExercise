using System;
using System.Threading;

namespace StopwatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            Thread.Sleep(3000);
            stopWatch.Stop();

            stopWatch.Start();
            Thread.Sleep(5000);
            stopWatch.Stop();

            //RESET//
            stopWatch.Reset();


            stopWatch.Start();
            Thread.Sleep(3000);
            stopWatch.Stop();

            stopWatch.Start();
            Thread.Sleep(5000);
            stopWatch.Stop();

        }
    }
}
