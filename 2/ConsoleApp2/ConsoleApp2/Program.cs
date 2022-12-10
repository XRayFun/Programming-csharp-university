using System;
class HelloWorld
{
    static void Main()
    {
        Random random = new Random();
        const int N = 10;
        int min = 10000;
        int max = -1;
        int[] vec = new int[N];
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < N; i++)
        {
            vec[i] = random.Next(1, 9);
            Console.Write("{0} ", vec[i]);
        }
        for (int i = 0; i < N; i++)
        {
            if (min > vec[i])
                min = vec[i];
        }
        Console.WriteLine($"\n{min}");
        for (int i = 0; i < N; i++)
        {
            if (max < vec[i])
                max = vec[i];
        }
        Console.WriteLine($"{max}");
    }
}
