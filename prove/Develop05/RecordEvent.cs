using System;
using System.Collections.Generic;
namespace Develop05{
public class RecordEvents : ConsoleMenuOption{
    public RecordEvents() : base(){}
    public override void Execute(ref List<Goal> goals){
        string badInput;
        int choice;
        Console.Out.WriteLine("The Goals Are:");
        for(int i = 0; i < goals.Count; i++){
            Console.Out.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }
        Console.Out.Write("Witch Goal do you want to aclomplish: ");
        badInput = Console.In.ReadLine();
        choice = int.Parse(badInput.Trim());
        base.AddPoints(goals[choice - 1].GetCompletionPoints());
        goals[choice - 1].RecordProgress();
    }
}
}