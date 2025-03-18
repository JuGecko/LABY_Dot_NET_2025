using System;
using System.IO;

namespace Zadanie_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("progZ4 fileIn.txt fileOut.txt word1 word2");
                return;
            }

            string inputFile = args[0];
            string outputFile = args[1];
            string wordToReplace = args[2];
            string replacementWord = args[3];

            if (!File.Exists(inputFile))
            {
                Console.WriteLine($"Plik '{inputFile}' nie istnieje.");
                return;
            }

            try
            {
                string content = File.ReadAllText(inputFile);
                content = content.Replace(wordToReplace, replacementWord);
                File.WriteAllText(outputFile, content);
                Console.WriteLine($"Plik '{outputFile}' zostal zapisany.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
