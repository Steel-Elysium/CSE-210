using System;

namespace Starfinder{
class ClassGeneration : ConsoleGUI{
    public void Action(params int[] arguments){
        string[] classes = {"Envoy", "Mechanic", "Mystic", "Operative", "Solarian", "Soldier", "Technomancer"};
        Console.Out.WriteLine("What Class do you wnat?");
        int rep = 0;
        foreach(string Pclass in classes){
            Console.Out.WriteLine($"{rep}: {Pclass}");
            rep++;
        }
        Console.Out.Write("Which Class: ");
        arguments[0] = int.Parse(Console.In.ReadLine());
    }
}
}