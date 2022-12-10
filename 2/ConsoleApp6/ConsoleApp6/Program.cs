using System;
class HelloWorld
{
    static void Main()
    {
        Random rnd = new Random();
        int N = 10;
        int[] vec = new int[N];
        for (int i = 0; i < N; i++)
        {
            vec[i] = rnd.Next(1, 9);
            Console.Write("{0} ", vec[i]);
        }
        int count = N;
        for (int i = 0; i < N; i++)
            for (int j = i + 1; j < N; j++)
                if (vec[i] == vec[j]) { count--; break; }
        Console.WriteLine($"\n{count}");
    }
}
