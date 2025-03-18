using System;
using System.IO;

namespace Zadanie_04
{
    internal class Program
    {
        static void Main(string[] args)
    {
        string path = args.Length > 0 ? args[0] : Directory.GetCurrentDirectory();

        if (!Directory.Exists(path))
        {
            Console.WriteLine($"Ścieżka '{path}' nie istnieje.");
            return;
        }

        Console.WriteLine($"Zawartość katalogu: {path}\n");

        foreach (var dir in Directory.GetDirectories(path))
            Console.WriteLine("[DIR]  " + Path.GetFileName(dir));

        foreach (var file in Directory.GetFiles(path))
            Console.WriteLine("       " + Path.GetFileName(file));
    }
}   