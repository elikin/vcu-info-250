// Four-Function Calculator
// Made by Eli Kin
// 9/28/18
using System;
using static System.Console;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Write("Please enter the first number you would like to enumerate: ");
            string in_one = ReadLine(); // prompts the user to input their first number
            float placeholder;
            if (float.TryParse(in_one, out placeholder) != true) // checks if the user input can be parsed, if it cannot be, the program goes to the error message
            {
                goto Error;
            }
            float first = float.Parse(in_one); // parses the user input
            Write("Please enter the operation (+,-,*, or /) you would like to perform: ");
            string operation = ReadLine(); // prompts the user to choose which operation they will perform
            Write("Please enter the second number you would like to enumerate: ");
            string in_two = ReadLine(); // prompts the user to input their second number
            if (float.TryParse(in_two, out placeholder) != true) // checks if the user input can be parsed, if it cannot be, the program goes to the error message
            {
                goto Error;
            }
            float second = float.Parse(in_two); // parses the user input
            float answer;
            if (operation == "+") // using a series of nested if else statements, the correct operation is performed
            {
                answer = first + second;
            }else
            {
                if(operation == "-")
                {
                    answer = first - second;
                }
                else
                {
                    if(operation == "*")
                    {
                        answer = first * second;
                    }
                    else
                    {
                        if(operation == "/")
                        {
                            answer = first / second;
                        }
                        else
                        {
                            goto Error; // if the user input for operation does not match any of the four appropriate options, the program goes to the error message
                        }
                    }
                }
            }
            if(second == 0 && operation == "/") // checks to see whether the second number is zero and the operation is division, and if so, outputs a special divide by zero error
            {
                WriteLine("The answer to your equation is indeterminate as division by zero is undefined. Press any key to start over.");
                goto Restart;
            }
            WriteLine("The answer to your equation is " + answer + ". Press any key to start over."); // displays the solution to the equation and prompts the user to press any key to restart

            Restart:
            ReadKey();
            Clear();
            goto Start;

            Error:
            WriteLine("Something went wrong. Press any key to start over."); // displays an error message in the console and prompts the user to press any key to restart
            goto Restart;
        }
    }
}