using System;
using static System.Console;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            WriteLine("Would you like to convert temperature (1), distance (2), or mass (3)?");
            double conversion = double.Parse(ReadLine());
            if (conversion == 1)
                {
                WriteLine("Would you like to convert from celsius (1), fahrenheit (2), or kelvin (3)?");
                int selection = int.Parse(ReadLine());
                WriteLine("How many degrees would you like to convert?");
                double input = double.Parse(ReadLine());
                if (selection == 1)
                    {
                    WriteLine(input + " celsius is the same as " + Math.Round((32 + ((9 * input) / 5)), 2, MidpointRounding.AwayFromZero) + " fahrenheit and " + (input + 273.15) + " kelvin.");
                    }
                    else if (selection == 2)
                {
                    WriteLine(input + " fahrenheit is the same as " + Math.Round((((input - 32) * 5) / 9), 2, MidpointRounding.AwayFromZero) + " celsius and " + Math.Round(((((input - 32) * 5) / 9) + 273.15), 2, MidpointRounding.AwayFromZero) + " kelvin.");
                }
                    else if (selection == 3)
                {
                    WriteLine(input + " kelvin is the same as " + (input - 273.15) + " celsius and " + Math.Round((32 + ((9 * (input - 273.15)) / 5)), 2, MidpointRounding.AwayFromZero) + " fahrenheit.");
                }
                    else
                {
                    goto Error;
                }
                }
            else if (conversion == 2)
            {
                WriteLine("Would you like to convert from inches (1), feet (2), miles (3), centimeters (4), or meters (5)?");
                int selection = int.Parse(ReadLine());
                WriteLine("How many of the unit would you like to convert?");
                double input = double.Parse(ReadLine());
                if (selection == 1)
                {
                    WriteLine(input + " inches is the same as " + (input / 12) + " feet, " + (input / 63360) + " miles, " + (input * 2.54) + " centimeters, and " + (input * 0.0254) + " meters.");
                }
                else if (selection == 2)
                {
                    WriteLine(input + " feet is the same as " + (input * 12) + " inches, " + (input / 5280) + " miles, " + (input * 30.48) + " centimeters, and " + (input * 0.3048) + " meters.");
                }
                else if (selection == 3)
                {
                    WriteLine(input + " miles is the same as " + (input * 63360) + " inches, " + (input * 5280) + " feet, " + (input * 160934) + " centimeters, and " + (input * 1609.34) + " meters.");
                }
                else if (selection == 4)
                {
                    WriteLine(input + " centimeters is the same as " + (input * 0.393701) + " inches, " + (input / 30.48) + " feet, " + (input / 160934) + " miles, and " + (input / 100) + " meters.");
                }
                else if (selection == 5)
                {
                    WriteLine(input + " meters is the same as " + (input * 39.3701) + " inches, " + (input / .3048) + " feet, " + (input / 1609.34) + " miles, and " + (input * 100) + " centimeters.");
                }
                else
                {
                    goto Error;
                }
            }
            else if (conversion == 3)
            {
                WriteLine("Would you like to convert from ounces (1), pounds (2), tons (3), grams (4), or kilograms (5)?");
                int selection = int.Parse(ReadLine());
                WriteLine("How many of the unit would you like to convert?");
                double input = double.Parse(ReadLine());
                if (selection == 1)
                {
                    WriteLine(input + " ounces is the same as " + (input / 16) + " pounds, " + (input / 32000) + " tons, " + (input * 28.3495) + " grams, and " + (input * .0283495) + " kilograms.");
                }
                else if (selection == 2)
                {
                    WriteLine(input + " pounds is the same as " + (input * 16) + " ounces, " + (input / 2000) + " tons, " + (input * 453.592) + " grams, and " + (input * .453592) + " kilograms.");
                }
                else if (selection == 3)
                {
                    WriteLine(input + " tons is the same as " + (input * 32000) + " ounces, " + (input * 2000) + " pounds, " + (input * 907185) + " grams, and " + (input * 907.185) + " kilograms.");
                }
                else if (selection == 4)
                {
                    WriteLine(input + " grams is the same as " + (input / 28.3495) + " ounces, " + (input / 453.592) + " pounds, " + (input / 907185) + " tons, and " + (input / 1000) + " kilograms.");
                }
                else if (selection == 5)
                {
                    WriteLine(input + " kilograms is the same as " + (input / 0.0283495) + " ounces, " + (input / 0.453592) + " pounds, " + (input / 907.185) + " tons, and " + (input * 1000) + " grams.");
                }
                else
                {
                    goto Error;
                }
            }
            Restart:
            WriteLine("Press any key to restart...");
            ReadKey();
            Clear();
            goto Start;
            Error:
            WriteLine("Something went wrong...");
            goto Restart;
        }
    }
}