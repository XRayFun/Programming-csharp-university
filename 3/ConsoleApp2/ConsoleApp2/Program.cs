using System;

public class Bank
{
    public int number, balance;
    public string fio;
    public Bank(int number, int balance, string fio)
    {
        this.number = number;
        this.balance = balance;
        this.fio = fio;
    }
    public void payment(int transaction)
    {
        balance = balance - transaction;
        Console.Write($"\nСписание: {transaction}\nТекущий баланс: {balance}\n");
    }
    public void refill(int transaction)
    {
        balance = balance + transaction;
        Console.Write($"\nПополнение: {transaction}\nТекущий баланс: {balance}\n");
    }
    public void push()
    {
        Console.Write($"\nНомер счета: {number}\nВладелец счета: {balance}\nБаланс счета: {fio}\n");
    }
}

class HelloWorld
{
    static void Main()
    {
        Bank person = new Bank(10111011, 3221658, "XRFGF");
        person.push();
        person.payment(1000);
        person.push();
        person.refill(1234);
        person.push();
    }
}