using System;
using static System.Console;

namespace Exam_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Write("What grade do you want for your yearly average? "); // Queries the user what grade they wish to receive for the year
                double DesiredGrade = double.Parse(ReadLine());
                Write("What percent of your yearly average is your exam? "); // Queries the user how much of the year their exam counts for
                double ExamWeight = double.Parse(ReadLine());
                double QuarterlyWeight = (100 - ExamWeight) / 400; // Calculates the weight of each quarter based on the weight of the exam
                Write("What grade did you get first quarter? "); // Queries the user what grade they got for the first quarter
                double FirstQuarter = double.Parse(ReadLine());
                Write("What grade did you get second quarter? ");
                double SecondQuarter = double.Parse(ReadLine());
                Write("What grade did you get third quarter? ");
                double ThirdQuarter = double.Parse(ReadLine());
                Write("What grade did you get fourth quarter? ");
                double FourthQuarter = double.Parse(ReadLine());
                double RequiredGrade = ExamWeight * (DesiredGrade - (QuarterlyWeight * FirstQuarter) - (QuarterlyWeight * SecondQuarter) - (QuarterlyWeight * ThirdQuarter) - (QuarterlyWeight * FourthQuarter)); // Calculates the required exam grade based on all previous inputs
                if (RequiredGrade > 100)
                {
                    Write("Uh oh! It looks like you'll have to get over 100 to get a " + DesiredGrade + ". (" + RequiredGrade + ")");
                }
                else
                {
                    if (RequiredGrade < 0)
                    {
                        Write("In order to get a " + DesiredGrade + " in your class, you don't even have to take the exam! Even if you get a zero you're good!");
                    }
                    else
                    {
                        Write("In order to a get a " + DesiredGrade + " you have to get a " + RequiredGrade + " on the exam!");
                    }
                }
                ReadKey();
                Clear();
            }
        }
    }
}