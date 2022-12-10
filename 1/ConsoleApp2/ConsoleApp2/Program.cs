using System;
class HelloWorld
{
    static void Main()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        if ((y <= 2 && y >= -2) && (x <= 2 && x >= -2))
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }
}
