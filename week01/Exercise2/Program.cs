using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);


        string letter = "";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //  Console.WriteLine($"your grade is {letter} ");

        // if (percent >= 70)
        {
            //Console.WriteLine("congratulations you passed this course");
        }
        //else
        {
            //letter

            // Console.WriteLine("we are sorry you didn't pass this course goodluck next time");
        }
        // Determine sign (+, -, or nothing)
        int lastDigit = percent % 10;
        if (letter != "F") // F has no + or -
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Special case: No A+
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        // Final grade output
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Pass/fail message
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class ");
        }
        else
        {
            Console.WriteLine("Keep trying, you can do better next time ");
        }



    }
}