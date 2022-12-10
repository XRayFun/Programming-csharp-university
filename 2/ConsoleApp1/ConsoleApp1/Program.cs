using System;
class HelloWorld
{
    static void Main()
    {
        Random random = new Random();
        const int N = 10;
        double J = 0;
        int[] vec = new int[N];
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < N; i++)
        {
            vec[i] = random.Next(1, 11);
            Console.Write("{0} ", vec[i]);
        }
        for (int i = 0; i < N; i++)
        {
            J = J + vec[i];
        }
        J = J / N;
        Console.WriteLine($"\n{J}");
    }
}
