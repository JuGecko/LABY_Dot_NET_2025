namespace Zadanie_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Baska";
            int number = 65;
            Console.WriteLine("Name:" + name + " its number:" + number);
            Console.WriteLine(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
        }

        public static System.Collections.IDictionary GetEnvironmentVariables()
        {
            return Environment.GetEnvironmentVariables();
        }
    }
}
