using System;
using System.Collections.Generic;
namespace Develop05{
public class SaveGoal : ConsoleMenuOption{
    public SaveGoal() : base(){}
    public override void Execute(ref List<Goal> goals){
        string location;
        Console.Out.Write("Enter the name of the file to save to: ");
        location = Console.In.ReadLine();
        FileManager.SaveGoals(goals, location);
    }
}
}