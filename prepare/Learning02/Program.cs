using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Learning_02.Program program = new Learning_02.Program();
        program.DoSomething();
    }
}
namespace Learning_02{
    public class Program{
        public void DoSomething(){
            Console.Out.WriteLine("hello World");
        }
    }
}