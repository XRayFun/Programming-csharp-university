using System;
using System.Collections.Generic;

class PR6_1
{
    static void Main()
    {
        List<int> Chisla = new List<int> { 1, 33, 73, 93, 5, 7, 9, 6, 7, 5, 8, 7, 99, 666 };
        Chisla.Reverse();

        var sortirovka_Chisla = new List<int>();

        foreach (int ch in Chisla)
        {
            if (ch > 4 && ch < 10) sortirovka_Chisla.Add(ch);
        }

        sortirovka_Chisla.Sort();

        foreach (int ch in sortirovka_Chisla)
        {
            Console.Write(ch + " ");
        }
    }
}
