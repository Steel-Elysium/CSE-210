using System;
using System.Collections.Generic;
namespace Develop05{
public class LoadGoal : ConsoleMenuOption{
    public LoadGoal() : base(){}
    public override void Execute(ref List<Goal> goals){
        int newPointValue = 0;
        string location;
        Console.Out.Write("Enter the name of the file to load from: ");
        location = Console.In.ReadLine();
        goals.Clear();
        goals = FileManager.LoadGoals(location);
        foreach(Goal goal in goals){
            newPointValue += goal.GetTotalCompletionPoints();
        }
        base.AddPoints(newPointValue);
    }
    
}
}