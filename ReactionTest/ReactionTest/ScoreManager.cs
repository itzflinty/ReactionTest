using System;
using System.Collections.Generic;
using System.Text;

namespace ReactionTest
{
    class ScoreManager
    {

        public static void UpdateScores(List<string> fileContents, string name, string bestTime)
        {
            foreach (string fileContent in fileContents)
            {
                string[] parts = fileContent.Split(":");
                Console.WriteLine(parts[0]);
                Console.WriteLine(parts[1]);
                Console.WriteLine(Int32.Parse(parts[1]));
                if (parts[0].ToLower() == name.ToLower())
                {
                    if (Int32.Parse(parts[1]) <= Int32.Parse(bestTime))
                    {
                        bestTime = parts[1].Trim();
                    }
                    fileContents.Remove(fileContent);
                    break;
                }
            }
            fileContents.Add($"{name}: {bestTime}");
        }
    }
}