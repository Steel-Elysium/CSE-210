using System;
using System.Collections.Generic;
namespace Develop05{
class MainLine{
    static void Main(string[] args){
        List<Goal> todoList = new List<Goal>();
        int menuOption, points = 0;
        ConsoleMenuOption option;
        bool repeat = true;
        while(repeat){
            Console.Out.WriteLine($"You have {points} points");
            menuOption = MenuChoice();
            switch(menuOption){
                case 1:
                    option = new MakeGoal();
                    break;
                case 2:
                    option = new ListGoal();
                    break;
                case 3:
                    option = new SaveGoal();
                    break;
                case 4:
                    option = new LoadGoal();
                    points = 0;
                    break;
                case 5:
                    option = new RecordEvents();
                    break;
                case 6:
                    option = new ConsoleMenuOption();
                    repeat = false;
                    break;
                default:
                    Console.Out.WriteLine("That is an incorrect option");
                    option = new ConsoleMenuOption();
                    break;
            }
            option.Execute(ref todoList);
            points += option.GetPoints();
        }
    }
    static int MenuChoice(){
        int userChoice;
        Console.Out.WriteLine("Menu Options: ");
        Console.Out.WriteLine("\t1. Create New Goal");
        Console.Out.WriteLine("\t2. List Goals");
        Console.Out.WriteLine("\t3. Save Goals");
        Console.Out.WriteLine("\t4. Load Goals");
        Console.Out.WriteLine("\t5. Record Events");
        Console.Out.WriteLine("\t6. Quit");
        Console.Out.Write("Select A choice from the Menu: ");
        userChoice = int.Parse(Console.In.ReadLine().Trim());
        return userChoice;
    }
}
}