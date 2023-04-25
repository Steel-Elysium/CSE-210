using System;


class Program
{
    static void Main(string[] args)
    {
        string repeat = "";
        Random r_num = new Random();
        Console.WriteLine("Hello Prep3 World!");
        do{
            int guess = -9999, random_guess;
            random_guess = r_num.Next(0,1000);
            Console.Out.WriteLine("Guess a random Number between 0 and 1,000");
            while (guess != random_guess){
                Console.Out.Write("What is your Guess: ");
                String usr_in = Console.In.ReadLine();
                guess = int.Parse(usr_in);
                if(guess < random_guess){
                    Console.Out.WriteLine("Your guess is lower than the number");
                }
                else if(guess > random_guess){
                    Console.Out.WriteLine("Your guess is higher than the number");
                }
                else{
                    Console.Out.WriteLine("You found the Number");
                }
            }
            Console.Out.Write("Do you want to guess again?: [Yes/No]: ");
            repeat = Console.In.ReadLine();
            repeat = repeat.ToLower();
        }while(repeat.Equals("yes"));
    }
}