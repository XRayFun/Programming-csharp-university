using System;
class HelloWorld
{
    static void Main()
    {
        int vvodday = Convert.ToInt32(Console.ReadLine());
        int day;
        int mesyash;
        int god;
        int god1;
        god = vvodday / 365;
        god1 = vvodday % 365;
        mesyash = god1 / 30;
        day = god1 % 30;
        Console.WriteLine($"{god} {mesyash} {day}");
    }
}
