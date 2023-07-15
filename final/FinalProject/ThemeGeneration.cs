using System;
namespace Starfinder{
class ThemeGeneration : ConsoleGUI {
    public void Action(params int[] arguments){
        string[] themes = {"Ace Pilot", "Priest", "Bounty Hunter", "Scholar", "Icon", "Spacefarer", "Mercenary", "Xenoseeker", "Outlaw"};
        int rep = 0;
        foreach(string pTheme in themes){
            Console.Out.WriteLine($"{rep}: {pTheme}");
            rep++;
        }
        Console.Out.Write("Which Race: ");
        arguments[0] = int.Parse(Console.In.ReadLine());
    }
}
}