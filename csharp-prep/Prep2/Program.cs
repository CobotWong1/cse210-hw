using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage of grade? ");
        string value = Console.ReadLine();
        int grade = int.Parse(value);
        
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        } 
        else if(grade >= 80)
        {
            letter = "B";
        }
        else if(grade >= 70)
        {
            letter = "C";
        }
        else if(grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int symbol = grade % 10;
        string sign = "";
        if (grade >= 93|| grade <60)
        {
            sign = "";
        }
        else
        {
            if (symbol >= 7)
            {
                sign = "+";
            }
            else if (symbol <= 2)
            {
                sign = "-";
            }   
            else
            {
                sign = "";
            }
        }

        Console.WriteLine($"Your grading is {letter}{sign}");
        Console.WriteLine("");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulation! You did a great job!");
        }
        else
        {
            Console.WriteLine("Do better next time!");
        }
    }
}