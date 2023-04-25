using System;


namespace Prep5{
class Program
{
    static void Main(string[] args){
        int number, squared;
        string name;
        console_Display_Welcome();
        name = console_prompt_username();
        number = console_prompt_number();
        squared = square(number);
        console_display_information(name, number,squared);
    }
    static void console_Display_Welcome(){
        Console.Out.WriteLine("Welcome to the program");
    }
    static void console_display_information(string name, int num, int square){
        Console.Out.WriteLine($"{name} the square of {num} is {square}.");
    }
    static string console_prompt_username(){
        String username;
        Console.Out.Write("What is your name: ");
        username = Console.In.ReadLine();
        return username;
    }
    static int console_prompt_number(){
        int number;
        string usr_in;
        Console.Out.Write("Enter in a number: ");
        usr_in = Console.In.ReadLine();
        number = int.Parse(usr_in);
        return number;
    }
    static int square(int num){
        int squared_num;
        squared_num = num * num;
        return squared_num;
    }
}
}