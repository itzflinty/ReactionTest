using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ReactionTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //Load the file
            string fileLoc = FileManager.FilePath();
            List<string> fileContents = FileManager.ReadFile(fileLoc);

            //Get Random number
            Random random = new Random();
            //Instantiate TimeCheck
            TimeCheck timeCheck = new TimeCheck();
            var bestTime = "";

            //Collect User's name
            Console.Write("Name:");
            var name = Console.ReadLine();

            //display random char and check speed of correct response
            for (int i = 0; i < 10; i++)
            {
                int a = random.Next(0, 26);
                char ch = (char)('a' + a);
                Console.WriteLine(ch);
                var newTime = timeCheck.SpeedCheck(ch);
                bestTime = timeCheck.SaveBestTime(newTime);
            }
            //Display the top score of the current run
            Console.WriteLine($"Best Score: {bestTime}");
            Console.WriteLine($"{name}:{bestTime}");
            Thread.Sleep(5000);

            ScoreManager.UpdateScores(fileContents, name, bestTime);
            string savedData = $"{name}: {bestTime}";

            FileManager.SaveFile(fileContents, fileLoc);
            Thread.Sleep(10000);
        }
    }
}
