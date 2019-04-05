// Maxie Broening, Ben Neuwirth, Eli Kin
// 12/14/18
// Unit Converter

using System;
using static System.Console;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int measurement = DisplayInstructions();
            double operand = GetOperand();
            if(measurement == 1)
            {
                Temperature(operand);
            }else if(measurement == 2)
            {
                Distance(operand);
            }else if(measurement == 3)
            {
                Mass(operand);
            }else
            {
                Error();
            }
            Restart();

        } // Runs all subsequent methods
        public static int DisplayInstructions()
        {
            WriteLine("Welcome! This application will help in convert metric unit to imperial ones and vice versa! Please start by choosing what measurement you'd like to convert by entering the number after it: Temperature (1),  Distance (2), or Mass (3)?");
            int measurement = int.Parse(ReadLine());
            return measurement;
        } // Displays initial instructions and returns the conversion type
        public static double GetOperand()
        {
            WriteLine("How many of the unit would you like to convert?");
            double operand = double.Parse(ReadLine());
            return operand;
        } // Returns the amount of the unit to convert
        public static void Temperature(double operand)
        {
            WriteLine("Would you like to convert from celsius (1), fahrenheit (2), or kelvin (3)?");
            int selection = int.Parse(ReadLine());
            if (selection == 1)
            {
                WriteLine(operand + " celsius is the same as " + Math.Round((32 + ((9 * operand) / 5)), 2, MidpointRounding.AwayFromZero) + " fahrenheit and " + (operand + 273.15) + " kelvin."); // These are all the conversion factors from celsius to the other standard temperature units
            }
            else if (selection == 2)
            {
                WriteLine(operand + " fahrenheit is the same as " + Math.Round((((operand - 32) * 5) / 9), 2, MidpointRounding.AwayFromZero) + " celsius and " + Math.Round(((((operand - 32) * 5) / 9) + 273.15), 2, MidpointRounding.AwayFromZero) + " kelvin."); // These are the conversion rates when starting with fahrenheit
            }
            else if (selection == 3)
            {
                WriteLine(operand + " kelvin is the same as " + (operand - 273.15) + " celsius and " + Math.Round((32 + ((9 * (operand - 273.15)) / 5)), 2, MidpointRounding.AwayFromZero) + " fahrenheit."); // This is the same, but starting with Kelvin
            }
            else
            {
                Error();
            }
        } // Does the calculations for temperature conversion
        public static void Distance(double operand)
        {
            WriteLine("Would you like to convert from inches (1), feet (2), miles (3), centimeters (4), or meters (5)?");
            int selection = int.Parse(ReadLine());
            if (selection == 1)
            {
                WriteLine(operand + " inches is the same as " + Math.Round((operand / 12), 4, MidpointRounding.AwayFromZero) + " feet, " + Math.Round((operand / 63360), 4, MidpointRounding.AwayFromZero) + " miles, " + Math.Round((operand * 2.54), 4, MidpointRounding.AwayFromZero) + " centimeters, and " + Math.Round((operand * 0.0254), 4, MidpointRounding.AwayFromZero) + " meters."); // Here are the operations to get from a number of inches to the other standard distance units we included
            }
            else if (selection == 2)
            {
                WriteLine(operand + " feet is the same as " + Math.Round((operand * 12), 4, MidpointRounding.AwayFromZero) + " inches, " + Math.Round((operand / 5280), 4, MidpointRounding.AwayFromZero) + " miles, " + Math.Round((operand * 30.48), 4, MidpointRounding.AwayFromZero) + " centimeters, and " + Math.Round((operand * 0.3048), 4, MidpointRounding.AwayFromZero) + " meters."); // Again, here are the operations to get to the different units, but instead of inches, it starts with feet
            }
            else if (selection == 3)
            {
                WriteLine(operand + " miles is the same as " + Math.Round((operand * 63360), 4, MidpointRounding.AwayFromZero) + " inches, " + Math.Round((operand * 5280), 4, MidpointRounding.AwayFromZero) + " feet, " + Math.Round((operand * 160934), 4, MidpointRounding.AwayFromZero) + " centimeters, and " + Math.Round((operand * 1609.34), 4, MidpointRounding.AwayFromZero) + " meters."); // Operations getting from miles to the other units
            }
            else if (selection == 4)
            {
                WriteLine(operand + " centimeters is the same as " + Math.Round((operand * 0.393701), 4, MidpointRounding.AwayFromZero) + " inches, " + Math.Round((operand / 30.48), 4, MidpointRounding.AwayFromZero) + " feet, " + Math.Round((operand / 160934), 4, MidpointRounding.AwayFromZero) + " miles, and " + Math.Round((operand / 100), 4, MidpointRounding.AwayFromZero) + " meters."); // Operations getting from centimeters to the other different units
            }
            else if (selection == 5)
            {
                WriteLine(operand  + " meters is the same as " + Math.Round((operand * 39.3701), 4, MidpointRounding.AwayFromZero) + " inches, " + Math.Round((operand / .3048), 4, MidpointRounding.AwayFromZero) + " feet, " + Math.Round((operand / 1609.34), 4, MidpointRounding.AwayFromZero) + " miles, and " + Math.Round((operand * 100), 4, MidpointRounding.AwayFromZero) + " centimeters."); // Operations starting with centimeters
            }
            else
            {
                Error();
            }
        } // Does the calculations for distance conversion
        public static void Mass(double operand)
        {
            WriteLine("Would you like to convert from ounces (1), pounds (2), tons (3), grams (4), or kilograms (5)?");
            int selection = int.Parse(ReadLine());
            if (selection == 1)
            {
                WriteLine(operand + " ounces is the same as " + Math.Round((operand / 16), 4, MidpointRounding.AwayFromZero) + " pounds, " + Math.Round((operand / 32000), 4, MidpointRounding.AwayFromZero) + " tons, " + Math.Round((operand * 28.3495), 4, MidpointRounding.AwayFromZero) + " grams, and " + Math.Round((operand * .0283495), 4, MidpointRounding.AwayFromZero) + " kilograms."); // Here are the mass conversion calculations when starting with ounces
            }
            else if (selection == 2)
            {
                WriteLine(operand + " pounds is the same as " + Math.Round((operand * 16), 4, MidpointRounding.AwayFromZero) + " ounces, " + Math.Round((operand / 2000), 4, MidpointRounding.AwayFromZero) + " tons, " + Math.Round((operand * 453.592), 4, MidpointRounding.AwayFromZero) + " grams, and " + Math.Round((operand * .453592), 4, MidpointRounding.AwayFromZero) + " kilograms."); // Operations to get to the different units when starting with pounds
            }
            else if (selection == 3)
            {
                WriteLine(operand + " tons is the same as " + Math.Round((operand * 32000), 4, MidpointRounding.AwayFromZero) + " ounces, " + Math.Round((operand * 2000), 4, MidpointRounding.AwayFromZero) + " pounds, " + Math.Round((operand * 907185), 4, MidpointRounding.AwayFromZero) + " grams, and " + Math.Round((operand * 907.185), 4, MidpointRounding.AwayFromZero) + " kilograms."); // Operations when starting with tons
            }
            else if (selection == 4)
            {
                WriteLine(operand + " grams is the same as " + Math.Round((operand / 28.3495), 4, MidpointRounding.AwayFromZero) + " ounces, " + Math.Round((operand / 453.592), 4, MidpointRounding.AwayFromZero) + " pounds, " + Math.Round((operand / 907185), 4, MidpointRounding.AwayFromZero) + " tons, and " + Math.Round((operand / 1000), 4, MidpointRounding.AwayFromZero) + " kilograms."); // Operations when starting with starting with grams
            }
            else if (selection == 5)
            {
                WriteLine(operand + " kilograms is the same as " + Math.Round((operand / 0.0283495), 4, MidpointRounding.AwayFromZero) + " ounces, " + Math.Round((operand / 0.453592), 4, MidpointRounding.AwayFromZero) + " pounds, " + Math.Round((operand / 907.185), 4, MidpointRounding.AwayFromZero) + " tons, and " + Math.Round((operand * 1000), 4, MidpointRounding.AwayFromZero) + " grams."); // Mass calculations when starting with kilograms
            }
            else
            {
                Error();
            }
        } // Does the calculations for mass conversion
        public static void Error() // Alerts the user they entered something incorrectly
        {
            Write("Uh oh! Looks like something went wrong.");
            Restart();
        }
        public static void Restart()
        {
            WriteLine("Press any key to restart...");
            ReadKey();
            Clear();
            Main(null);
        } // Restarts the program
    }
}