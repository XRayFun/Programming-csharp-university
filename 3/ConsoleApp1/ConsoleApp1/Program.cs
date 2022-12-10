using System;
class Person
{
    public string firstName;
    public string lastName;
}
class Student : Person
{
    public string mark;
}
class Worker : Person
{
    public int wage;
    public int hours;
    public int Zarplata()
    {
        int zarplata = wage * hours;
        return zarplata;
    }
}

class HelloWorld
{
    static void Main()
    {
        Worker S = new Worker();
        S.wage = 5000;
        S.hours = 24;
        Console.Write(S.Zarplata());

    }
}
