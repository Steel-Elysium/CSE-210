using System;
using System.Collections.Generic;
namespace Develop05{
public class ListGoal : ConsoleMenuOption{
    public ListGoal() : base(){}
    public override void Execute(ref List<Goal> goals){
        Console.Out.WriteLine("The Goals Are: ");
        for(int i = 0; i < goals.Count; i++){
            Console.Out.WriteLine($"{i}. {goals[i].Display()}");
        }
    }
}
}