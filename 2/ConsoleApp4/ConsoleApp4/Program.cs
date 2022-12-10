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
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = 0; j < N - 1; j++)
            {
                if (vec[j] > vec[j + 1])
                {
                    int tmp = vec[j];
                    vec[j] = vec[j + 1];
                    vec[j + 1] = tmp;
                }
            }
        }
        Console.WriteLine("\nИзменённый массив");
        for (int i = 0; i < N; i++)
        {
            Console.Write("{0} ", vec[i]);
        }
    }
}
