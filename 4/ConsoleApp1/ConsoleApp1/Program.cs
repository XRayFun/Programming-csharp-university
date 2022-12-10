using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> Chisla = new List<int>() { 12, 6, 54, 91, -3, -12, -8, 4, 666, -32, -8, -3, -12, -666, 312, 423, 654, -13, -123, -64 };
        Dictionary<int, int> Kolvo = new Dictionary<int, int>();
        foreach (int p in Chisla)
        {
            if (p < 1)
            {
                if (Kolvo.ContainsKey(p))
                    Kolvo[p] += 1;
                else
                    Kolvo.Add(p, 1);
            }
        }
        foreach (var k in Kolvo) Chisla.RemoveAll(y => y == k.Key);
        Console.WriteLine("Положительные числа: ");
        foreach (int p in Chisla) Console.Write(p + " ");
        Console.WriteLine("\nОтрицательные числа и их количество: ");
        foreach (var k in Kolvo) Console.WriteLine(k.Key + " " + k.Value);
    }
}
