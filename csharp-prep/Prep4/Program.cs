using System;
using System.Collections.Generic;

namespace Prep4{
    class Program
    {
        static void Main(string[] args)
        {
            int next_num, sum = 0, small, large, pos_small = 0;
            float avg;
            string usr_in;
            List<int> numbers = new List<int>();
            Console.Out.WriteLine("Enter a list of numbers, type 0 when finished.");
            do{
                Console.Out.Write("Enter Number: ");
                usr_in = Console.In.ReadLine();
                next_num = int.Parse(usr_in);
                if (next_num != 0){
                    numbers.Add(next_num);
                }
            // Calculating Varables to prunt to $usr
            }while(next_num != 0);
            foreach(int nums in numbers){
                sum += nums;
            }
            numbers.Sort();
            small = numbers[0];
            large = numbers[^1];
            avg = (float)sum / numbers.Count;
            for(int i = 0; i < numbers.Count; i++){
                if(numbers[i] > 0){
                    pos_small = numbers[i];
                    break;
                }
            }
            // Printing to $usr
            Console.Out.WriteLine($"The sum is {sum}");
            Console.Out.WriteLine($"The Avrage is {avg}");
            Console.Out.WriteLine($"The Smallest number is {small}");
            if(pos_small != 0){
                Console.Out.WriteLine($"The Smallest Positive Number is {pos_small}");
            }
            Console.Out.WriteLine($"The Largest number is {large}");
            Console.Out.WriteLine("The sorted list is:");
            foreach(int num in numbers){
                Console.Out.WriteLine($"{num}");
            }
        }
    }
}