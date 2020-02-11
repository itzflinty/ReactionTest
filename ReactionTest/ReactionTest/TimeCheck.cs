using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ReactionTest
{

    class TimeCheck
    {
        Stopwatch stopwatch = new Stopwatch();
        string newBestTime = "";
        long bestTime;
        long timeSpan;
        long decoy;

        public long SpeedCheck(char ch)
        {
            if (!stopwatch.IsRunning)
            {
                stopwatch.Start();
            }
            var ans = Console.ReadLine();

            if (ch.ToString() == ans)
            {
                //Console.WriteLine("Correct");
                stopwatch.Stop();
                //Console.WriteLine(stopwatch.Elapsed);
                timeSpan = stopwatch.ElapsedMilliseconds;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Try again");
                SpeedCheck(ch);
            }
            stopwatch.Reset();
            return timeSpan;
        }
        public string SaveBestTime(long timeSpan)
        {
            if (bestTime == decoy)
            {
                bestTime = timeSpan;
                newBestTime = bestTime.ToString();
            }
            else if (timeSpan < bestTime)
            {
                bestTime = timeSpan;
                newBestTime = bestTime.ToString();
            }
            return newBestTime;
        }
    }
}