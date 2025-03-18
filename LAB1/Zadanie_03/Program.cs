namespace Zadanie_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Parametry wejsciowe ");
            foreach (var param in ParseArguments(args))
                Console.WriteLine($"{param.Key}: {param.Value}");

            Console.WriteLine("\n Zmienne srodowiskowe ");
            foreach (System.Collections.DictionaryEntry envVar in Environment.GetEnvironmentVariables())
                Console.WriteLine($"{envVar.Key}: {envVar.Value}");
        }

        static Dictionary<string, string?> ParseArguments(string[] args)
        {
            var parameters = new Dictionary<string, string?>();
            for (int i = 0; i < args.Length; i++)
                if (args[i].StartsWith("--"))
                    parameters[args[i][2..]] = (i + 1 < args.Length && !args[i + 1].StartsWith("--")) ? args[++i] : null;
            return parameters;
        }
    }
}