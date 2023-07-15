using System;
namespace Starfinder{
class RaceGeneration : ConsoleGUI{
    public void Action(params int[] arguments){
        string[] races = {"Android", "Human", "Kasatha", "Lachunta (Damaya)", "Lachunta (Korasha)", "Shirren", "Vesk", "Ysoki"};
        int rep = 0;
        foreach(string pRace in races){
            Console.Out.WriteLine($"{rep}: {pRace}");
            rep++;
        }
        Console.Out.Write("Which Race: ");
        arguments[0] = int.Parse(Console.In.ReadLine());
    }
}
}