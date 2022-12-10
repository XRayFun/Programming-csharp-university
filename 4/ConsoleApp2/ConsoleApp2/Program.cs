using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> Chisla1 = new List<int>() { 254, 6, 666, 21, 85, 123, 91, 33, 99, 10 };
        List<int> Chisla2 = new List<int>() { 254, 124, 123, 83, 33, 91, 100, 2, 15, 77 };
        var Inter = Chisla1.Intersect(Chisla2);
        Console.WriteLine("Пересечение чисел из двух списков:");
        foreach (int a in Inter)
        {
            Console.Write(a + " ");
        }
    }
}