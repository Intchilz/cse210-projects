using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int figure = int.Parse(input);

        string letter = "";

        if ( figure >= 93)
        {
            letter = "A";
        }
        else if (figure >= 90 && figure <= 92)
        {
            letter = "A-";
        }
        else if (figure >= 87 && figure <= 89)
        {
            letter = "B+";
        }
        else if (figure >= 83 && figure <= 86)
        {
            letter = "B";
        }
        else if (figure >= 80 && figure <= 82)
        {
            letter = "B-";
        }
        else if (figure >= 77 && figure <= 79)
        {
            letter = "C+";
        }
        else if (figure >= 73 && figure <= 76)
        {
            letter = "C";
        }
        else if (figure >= 70 && figure <= 72)
        {
            letter = "C-";
        }
        else if (figure >= 67 && figure <= 69)
        {
            letter = "D+";
        }
        else if (figure >= 63 && figure <= 66)
        {
            letter = "D";
        }
        else if (figure >= 60 && figure <= 62)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (figure >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}