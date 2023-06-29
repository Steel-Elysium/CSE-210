using System;
using System.Collections.Generic;
namespace Develop05{
public class MakeGoal : ConsoleMenuOption {
    public MakeGoal() : base(){}
    public override void Execute(ref List<Goal> goals){
        string inputGarbage, name, discription;
        int choice, points, bonusPoints, requiredAttempts;
        bool good = false;
        while(!good){
            Console.Out.WriteLine("The Types of Goals are:");
            Console.Out.WriteLine("\t1: Simple Goal");
            Console.Out.WriteLine("\t2: Eternal Goal");
            Console.Out.WriteLine("\t3: Checklist Goal");
            Console.Out.Write("Select a Choice form the Menu: ");
            inputGarbage = Console.In.ReadLine();
            choice = int.Parse(inputGarbage.Trim());
            switch(choice){
                case 1:
                    Console.Out.Write("Enter The name of your Goal: ");
                    name = Console.In.ReadLine();
                    Console.Out.Write("What is a short discription of the Goal: ");
                    discription = Console.In.ReadLine();
                    Console.Out.Write("How meny points is this goal worth: ");
                    inputGarbage = Console.In.ReadLine();
                    points = int.Parse(inputGarbage.Trim());
                    goals.Add(new Goal(name, discription, points));
                    good = true;
                    break;
                case 2:
                    Console.Out.Write("Enter The name of your Eternal Goal: ");
                    name = Console.In.ReadLine();
                    Console.Out.Write("What is a short discription of the Eternal Goal: ");
                    discription = Console.In.ReadLine();
                    Console.Out.Write("How meny points is this Eternal Goal worth: ");
                    inputGarbage = Console.In.ReadLine();
                    points = int.Parse(inputGarbage.Trim());
                    goals.Add(new Eternal(name, discription, points));
                    good = true;
                    break;
                case 3:
                    Console.Out.Write("Enter The name of your Goal: ");
                    name = Console.In.ReadLine();
                    Console.Out.Write("What is a short discription of the Goal: ");
                    discription = Console.In.ReadLine();
                    Console.Out.Write("How meny points is this goal worth: ");
                    inputGarbage = Console.In.ReadLine();
                    points = int.Parse(inputGarbage.Trim());
                    Console.Out.Write("How meny times do you need to do this goal: ");
                    inputGarbage = Console.In.ReadLine();
                    requiredAttempts = int.Parse(inputGarbage.Trim());
                    Console.Out.Write("How meny bonus points do you get when completing this Goal: ");
                    inputGarbage = Console.In.ReadLine();
                    bonusPoints = int.Parse(inputGarbage.Trim());
                    goals.Add(new Checklist(name, discription, points, requiredAttempts, bonusPoints));
                    good = true;
                    break;
                default:
                Console.Out.WriteLine("That is an invalid choice!");
                break;
            }
        }
    }
}
}