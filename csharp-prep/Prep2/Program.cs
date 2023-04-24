using System;

class Program
{
    static void Main(string[] args)
    {
        int grade_number;
        string grade_letter, usr_in;
        Console.WriteLine("Hello Prep2 World!\n");
        Console.Out.Write("What is the Grade number? ");
        usr_in = Console.In.ReadLine();
        grade_number = int.Parse(usr_in);
        grade_letter = "";
        if(grade_number / 10 >= 9){
            grade_letter += "A";
        }
        else if( grade_number / 10 == 8){
            grade_letter += "B";
        }
        else if(grade_number / 10 == 7){
            grade_letter += "C";
        }
        else if (grade_number / 10 == 6){
            grade_letter += "D";
        }
        else{
            grade_letter += "F";
        }
        if (grade_number % 10 < 3){
            grade_letter += "-";
        }
        else if(grade_number % 10 >= 7){
            grade_letter += '+';
        }
        else{
            grade_letter += "";
        }
        Console.Out.WriteLine($"Your Grade of {grade_number} is a {grade_letter}!");
    }
}