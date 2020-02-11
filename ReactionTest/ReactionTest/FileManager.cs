using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ReactionTest
{
    class FileManager
    {
        public static string FilePath()
        {
            string filePath = @"C:\Dev\C#\ReactionTest\Scores.txt";
            return filePath;
        }
        public static List<string> ReadFile(string filePath)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            return (lines);
        }

        public static void SaveFile(List<string> lines, string filePath)
        {

            File.WriteAllLines(filePath, lines);

            Console.Clear();
            Console.WriteLine("Top Scores");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}