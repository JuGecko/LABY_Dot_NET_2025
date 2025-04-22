//podać definicję własnej klasy zgodnej z pętlą typu foreach
using System;
using System.Collections;
using System.Collections.Generic;
using Zadanie_07;

class Program
{
    static void Main()
    {
        MyCollection numbers = new MyCollection();
        numbers.Add(7);
        numbers.Add(3);
        numbers.Add(5);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}


