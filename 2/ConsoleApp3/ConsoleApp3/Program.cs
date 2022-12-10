using System;
class HelloWorld
{
    static void Main()
    {
        Random random = new Random();
        const int N = 10;
        int J = 0;
        int[] vec = new int[N];
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < N; i++)
        {
            vec[i] = random.Next(1, 9);
            Console.Write("{0} ", vec[i]);
        }
        for (int i = 0; i < N; i++)
        {
            for (int j = i + 1; j < N - 1; j++)
            {
                if (vec[i] == vec[j + 1])
                    J = J + 1;
            }
        }
        Console.Write($"\n{J}");
    }
}
