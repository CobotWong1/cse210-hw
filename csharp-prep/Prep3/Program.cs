using System;

class Program
{
    static void Main(string[] args)
    { 
    Random randomGenerator = new Random();
    int number = randomGenerator.Next(1,100);
    int guess = 0;
    while (guess != number)
        {
        Console.Write("What is your guess? ");
        string answer = Console.ReadLine();
        guess = int.Parse(answer);
        }
        if (guess < number){
            Console.WriteLine("Higher");
        }
        else if (number < guess){
            Console.WriteLine("Lower");
        }
        }
    }