using System;
using System.Threading;
class HelloWorld
{
    static void Main()
    {
        Console.Write("Введите своё число: ");
        long number = Convert.ToInt64(Console.ReadLine());
        new Thread(() => Find(number)).Start();
    }
    static void Find(long number)
    {
        for (long i = 1; i <= number; i++)
        {
            if (number % i == 0)
                Console.WriteLine($"Число {number} делится без остатка на {i}");
        }
    }
}
