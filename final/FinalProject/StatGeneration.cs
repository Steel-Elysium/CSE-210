using System.Diagnostics.Contracts;
using System;

namespace Starfinder{
class StatGeneration : ConsoleGUI{
    private static Random _rand = new Random();
    public void Action(params int[] arguments){
        int choice;
        Console.Out.WriteLine("Pick an option form the list:\n\t1) Pick unique stats\n\t2) Random Stats");
        Console.Out.Write("What option: ");
        choice = int.Parse(Console.In.ReadLine());
        switch (choice){
            case 1:
                Console.Out.Write("\nSTR: ");
                arguments[0] = int.Parse(Console.In.ReadLine());
                Console.Out.Write("\nDEX: ");
                arguments[1] = int.Parse(Console.In.ReadLine());
                Console.Out.Write("\nCON: ");
                arguments[2] = int.Parse(Console.In.ReadLine());
                Console.Out.Write("\nINT: ");
                arguments[3] = int.Parse(Console.In.ReadLine());
                Console.Out.Write("\nWIS: ");
                arguments[4] = int.Parse(Console.In.ReadLine());
                Console.Out.Write("\nCHA: ");
                arguments[5] = int.Parse(Console.In.ReadLine()); 
            break;
            case 2:
            Console.Out.WriteLine("\nGenerating Stats");
            for(int i = 0; i < 6; i++){
                arguments[i] = GetStat();
            }
            Console.Out.WriteLine($"STR: {arguments[0]}");
            Console.Out.WriteLine($"DEX: {arguments[1]}");
            Console.Out.WriteLine($"CON: {arguments[2]}");
            Console.Out.WriteLine($"INT: {arguments[3]}");
            Console.Out.WriteLine($"WIS: {arguments[4]}");
            Console.Out.WriteLine($"CHA: {arguments[5]}");
            break;
            default:
            break;
        }
    }
    private int GetStat(){
        int[] rolls = new int[4];
        int lowestRoll = 0, sum = 0;
        for(int i = 0; i < 4; i++){
            rolls[i] = _rand.Next(1,7);
        }
        for(int i = 1; i < 4; i++){
            if(rolls[lowestRoll] > rolls[i]){
                lowestRoll = i;
            }
        }
        for(int i = 0; i < 4; i++){
            if(i != lowestRoll){
                sum += rolls[i];
            }
        }
        return sum;
    }
}
}