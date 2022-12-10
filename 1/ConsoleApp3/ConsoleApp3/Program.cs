class HelloWorld
{
    static void Main()
    {
        Random rnd = new Random();
        int iznchislo = rnd.Next(0, 100);
        int moychislo;
        do
        {
            moychislo = Convert.ToInt32(Console.ReadLine());
            if (moychislo > iznchislo)
                Console.WriteLine("Число меньше");
            else if (moychislo < iznchislo)
                Console.WriteLine("Число больше");
        }
        while (moychislo != iznchislo);
        Console.WriteLine("Угадал число");
    }
}
