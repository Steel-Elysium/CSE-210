using System;
using System.Collections.Generic;

namespace Starfinder{
class Program
{
    static void Main(string[] args){
        //Console.WriteLine("Hello FinalProject World!");
        bool repeat = true;
        int[] stats = new int[6], attributes = new int[3];
        string rep;
        Character madeChar;
        List<ConsoleGUI> runStack = new List<ConsoleGUI>();
        do{
            runStack.Clear();
            runStack.Add(new StatGeneration());
            runStack.Add(new ClassGeneration());
            runStack.Add(new RaceGeneration());
            runStack.Add(new ThemeGeneration());
            Console.Clear();
            runStack[0].Action(stats);
            Console.Clear();
            for(int i = 0; i < 3; i++){
                runStack[i+1].Action(attributes[i]);
                Console.Clear();
            }
            madeChar = new Character(stats, attributes);
            Console.Clear();
            Console.Out.WriteLine(madeChar.Display());
            Console.Out.Write("\nDo you want to make a new Charater?: [Y/N]: ");
            rep = Console.In.ReadLine();
            if(rep.ToLower().StartsWith('n')){
                repeat = false;
            }
        }while(repeat);
    }
}
}