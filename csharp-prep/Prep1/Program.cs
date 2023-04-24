using System;

class Program
{
    static void Main(string[] args)
    {
        string first_name, last_name;
        Console.WriteLine("Hello Prep1 World!\n");
        Console.Out.Write("What is your First name? ");
        first_name = Console.In.ReadLine();
        Console.Out.Write("What is your last name? ");
        last_name = Console.In.ReadLine();
        Console.Out.WriteLine($"\nYou are {last_name}, {first_name} {last_name}");
    }
}