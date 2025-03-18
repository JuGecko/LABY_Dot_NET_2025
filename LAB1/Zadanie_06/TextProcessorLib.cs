namespace TextProcessorLib
{
    public class TextProcessor
    {
        public static string ReplaceWord(string text, string oldWord, string newWord)
        {
            return text.Replace(oldWord, newWord);
        }
    }
}