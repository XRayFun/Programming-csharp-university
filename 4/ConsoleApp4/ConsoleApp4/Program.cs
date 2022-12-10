using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string sent = "раз раз раз геншин два два девять десять два пять четыре миллион";
        Dictionary<string, int> Slova = new Dictionary<string, int>();
        string a = "";
        foreach (var b in sent)
        {
            if (Char.IsWhiteSpace(b) == false)
            {
                a = a + b;
            }
            if (Char.IsWhiteSpace(b) == true)
            {
                if (Slova.ContainsKey(a))
                    Slova[a] += 1;
                else
                    Slova.Add(a, 1);
                a = "";
            }
        }
        if (Slova.ContainsKey(a))
            Slova[a] += 1;
        else
            Slova.Add(a, 1);
        Console.WriteLine("Повтор слов: ");
        foreach (var b in Slova)
        {
            if (b.Value % 2 != 0)
                Console.WriteLine(b.Key + " " + b.Value);
        }
    }
}
