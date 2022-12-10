class HelloWorld
{
    static void Main()
    {
        int second = Convert.ToInt32(Console.ReadLine());
        int day, hour, min, sec;
        day = second / 86400;
        hour = (second % 86400) / 3600;
        min = ((second % 86400) % 3600) / 60;
        sec = ((second % 86400) % 3600) % 60;
        
        

        Console.WriteLine($"{day} {hour} {min} {sec}");
    }
}

