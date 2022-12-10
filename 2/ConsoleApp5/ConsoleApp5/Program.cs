using System;
class HelloWorld
{
    static void Main()
    {
        Random random = new Random();
        const int N = 10;
        int[] vec = new int[N];
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < N; i++)
        {
            vec[i] = random.Next(1, 9);
            Console.Write("{0} ", vec[i]);
        }
        Console.WriteLine("\nЧётные элементы");
        for (int i = 0; i < N; i++)
        {
            if (vec[i] % 2 == 0)
            {
                Console.Write("{0} ", vec[i]);
            }
        }
        Console.WriteLine("\nНечётные элементы");
        for (int i = 0; i < N; i++)
        {
            if (vec[i] % 2 != 0)
            {
                Console.Write("{0} ", vec[i]);
            }
        }
    }
}
