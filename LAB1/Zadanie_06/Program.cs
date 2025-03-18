using TextProcessorLib;

namespace Zadanie_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("ConsoleApp fileIn.txt fileOut.txt oldWord newWord");
                return;
            }

            string inputFile = args[0];
            string outputFile = args[1];
            string wordToReplace = args[2];
            string replacementWord = args[3];

            if (!File.Exists(inputFile))
            {
                Console.WriteLine($"Plik wejsciowy '{inputFile}' nie istnieje.");
                return;
            }

            try
            {
                string content = File.ReadAllText(inputFile);
                content = TextProcessor.ReplaceWord(content, wordToReplace, replacementWord);
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

