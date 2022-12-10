using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> Chisla = new List<int>() { 233, 243, 233, 12, -3, -60, 32, 32, 32, 100 };
        Dictionary<int, int> Perecechenie = new Dictionary<int, int>();
        foreach (int a in Chisla)
        {
            if (Perecechenie.ContainsKey(a))
                Perecechenie[a] += 1;
            else
                Perecechenie.Add(a, 1);
        }
        foreach (var b in Perecechenie)
        {
            if (b.Value % 2 != 0)
            {
                Chisla.RemoveAll(y => y == b.Key);
            }
        }
        Console.WriteLine("Перечисление чисел: ");
        foreach (int a in Chisla) Console.Write(a + " ");
        Console.WriteLine("\nПовторы: ");
        foreach (var b in Perecechenie) Console.WriteLine(b.Key + " " + b.Value);
    }
}