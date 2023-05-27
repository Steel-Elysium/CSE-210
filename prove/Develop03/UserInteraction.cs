using System;
namespace Memorize{
static class UserInteraction{
    ///<summary>
    ///
    ///</summary>
    public static int Menu(){
        int responce; 
        Console.Out.WriteLine("\n\n");
        Console.Out.WriteLine("Welcome to the scripture memorization tool!");
        Console.Out.WriteLine("The options are:");
        Console.Out.WriteLine("1: Display the Scripture");
        Console.Out.WriteLine("2: Enter a new scripture");
        Console.Out.WriteLine("3: Hide words in the scripture");
        Console.Out.WriteLine("4: Unhide all words");
        Console.Out.WriteLine("5: Redisplay the menu options");
        Console.Out.WriteLine("6: Exit");
        Console.Out.Write("\nEnter in choice: ");
        string choice = Console.In.ReadLine();
        try{
            responce = int.Parse(choice.Trim());
        }
        catch (System.Exception){
            Console.Out.WriteLine("Invalid input");
            return 4;
            throw;
        }
        return responce;
    }
    public static void Display(Scripture memorize){
        Console.Clear();
        string scripture = memorize.GetWords();
        Console.Out.WriteLine(scripture);
        Console.Out.WriteLine("\n\n");
        Console.Out.WriteLine("Press enter to return to menu");
        Console.In.ReadLine();
    }
    public static Scripture EnterScripture(){
        Scripture memorize = new Scripture();
        string scripture;
        Console.Out.Write("Enter in the scripture that you want to memorize: ");
        scripture = Console.In.ReadLine();
        memorize.SetWords(scripture.Trim());
        return memorize;
    }
    public static int HideScripture(){
        int amountToHide;
        string userInput;
        Console.Out.Write("Enter in how meny words to hide: ");
        userInput = Console.In.ReadLine();
        try{
            amountToHide = int.Parse(userInput.Trim());
        }
        catch (System.Exception){
            Console.Out.WriteLine("Invalid input");           
            return 0;
            throw;
        }
        return amountToHide;
    }
}
}