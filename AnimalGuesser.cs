// Eli Kin
// Animal Guesser
// 3/11/19

using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Boolean answer;
            WriteLine("Animal Guesser - Please type out True or False");
            WriteLine("Does it lay eggs?");
            answer = bool.Parse(ReadLine());
            if (answer == true)
            {
                WriteLine("Is it usually in the water?");
                answer = bool.Parse(ReadLine());
                if (answer == true)
                {
                    WriteLine("Is it a predator?");
                    answer = bool.Parse(ReadLine());
                    if (answer == true)
                    {
                        WriteLine("Can it walk on land?");
                        answer = bool.Parse(ReadLine());
                        if (answer == true)
                        {
                            WriteLine("My guess is Crocodile");
                        }
                        else if (answer == false)
                        {
                            WriteLine("My guess is Shark");
                        }
                    }
                    else if (answer == false)
                    {
                        WriteLine("Does it have a hard outer shell?");
                        answer = bool.Parse(ReadLine());
                        if (answer == true)
                        {
                            WriteLine("Does it have pincers?");
                            answer = bool.Parse(ReadLine());
                            if (answer == true)
                            {
                                WriteLine("My guess is Crustacean");
                            }
                            else if (answer == false)
                            {
                                WriteLine("My guess is Sea Turtle");
                            }
                        }
                        else if (answer == false)
                        {
                            WriteLine("Does it have a bill?");
                            answer = bool.Parse(ReadLine());
                            if (answer == true)
                            {
                                WriteLine("My guess is Platypus");
                            }
                            else if (answer == false)
                            {
                                WriteLine("My guess is Fish");
                            }
                        }
                    }
                }
                else if (answer == false)
                {
                    WriteLine("Does it have legs?");
                    answer = bool.Parse(ReadLine());
                    if (answer == true)
                    {
                        WriteLine("Does it have feathers?");
                        answer = bool.Parse(ReadLine());
                        if (answer == true)
                        {
                            WriteLine("My guess is Bird");
                        }
                        else if (answer == false)
                        {
                            WriteLine("Does it have more than four legs?");
                            answer = bool.Parse(ReadLine());
                            if (answer == true)
                            {
                                WriteLine("My guess is Arthropod");
                            }
                            else if (answer == false)
                            {
                                WriteLine("Is it born as a tadpole?");
                                answer = bool.Parse(ReadLine());
                                if (answer == true)
                                {
                                    WriteLine("My guess is Frog");
                                }
                                else if (answer == false)
                                {
                                    WriteLine("My guess is Lizard");
                                }
                            }
                        }
                    }
                    else if (answer == false)
                    {
                        WriteLine("My guess is Snake");
                    }
                }
            }
            else if (answer == false)
            {
                WriteLine("Does it walk on four legs?");
                answer = bool.Parse(ReadLine());
                if (answer == true)
                {
                    WriteLine("Do you eat it?");
                    answer = bool.Parse(ReadLine());
                    if (answer == true)
                    {
                        WriteLine("Is it pink?");
                        answer = bool.Parse(ReadLine());
                        if (answer == true)
                        {
                            WriteLine("My guess is Pig");
                        }
                        else if (answer == false)
                        {
                            WriteLine("Does it have wool?");
                            answer = bool.Parse(ReadLine());
                            if (answer == true)
                            {
                                WriteLine("My guess is Sheep");
                            }
                            else if (answer == false)
                            {
                                WriteLine("My guess is Cow");
                            }
                        }
                    }
                    else if (answer == false)
                    {
                        WriteLine("Is it big enough to ride?");
                        answer = bool.Parse(ReadLine());
                        if (answer == true)
                        {
                            WriteLine("Does it live in the savannah?");
                            answer = bool.Parse(ReadLine());
                            if (answer == true)
                            {
                                WriteLine("Does it have tusks?");
                                answer = bool.Parse(ReadLine());
                                if (answer == true)
                                {
                                    WriteLine("My guess is Elephant");
                                }
                                else if (answer == false)
                                {
                                    WriteLine("Is it known for its long neck?");
                                    answer = bool.Parse(ReadLine());
                                    if (answer == true)
                                    {
                                        WriteLine("My guess is Giraffe");
                                    }
                                    else if (answer == false)
                                    {
                                        WriteLine("My guess is Zebra");
                                    }
                                }
                            }
                            else if (answer == false)
                            {
                                WriteLine("Does it eat meat?");
                                answer = bool.Parse(ReadLine());
                                if (answer == true)
                                {
                                    WriteLine("Would it willingly venture into the water?");
                                    answer = bool.Parse(ReadLine());
                                    if (answer == true)
                                    {
                                        WriteLine("My guess is Bear");
                                    }
                                    else if (answer == false)
                                    {
                                        WriteLine("My guess is Wildcat");
                                    }
                                }
                                else if (answer == false)
                                {
                                    WriteLine("My guess is Horse");
                                }
                            }
                        }
                        else if (answer == false)
                        {
                            WriteLine("Can it climb trees?");
                            answer = bool.Parse(ReadLine());
                            if (answer == true)
                            {
                                WriteLine("Does it meow?");
                                answer = bool.Parse(ReadLine());
                                if (answer == true)
                                {
                                    WriteLine("My guess is Cat");
                                }
                                else if (answer == false)
                                {
                                    WriteLine("My guess is Ape");
                                }
                            }
                            else if (answer == false)
                            {
                                WriteLine("Is it a pest?");
                                answer = bool.Parse(ReadLine());
                                if (answer == true)
                                {
                                    WriteLine("My guess is Mouse");
                                }
                                else if (answer == false)
                                {
                                    WriteLine("Does it like carrots?");
                                    answer = bool.Parse(ReadLine());
                                    if (answer == true)
                                    {
                                        WriteLine("My guess is Rabbit");
                                    }
                                    else if (answer == false)
                                    {
                                        WriteLine("Is it known for jumping off cliffs?");
                                        answer = bool.Parse(ReadLine());
                                        if (answer == true)
                                        {
                                            WriteLine("My guess is Lemming");
                                        }
                                        else if (answer == false)
                                        {
                                            WriteLine("My guess is Dog");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (answer == false)
                {
                        WriteLine("Does it have wings?");
                        answer = bool.Parse(ReadLine());
                        if (answer == true)
                        {
                            WriteLine("My guess is Bat");
                        }
                        else if (answer == false)
                        {
                            WriteLine("Is it a marsupial?");
                            answer = bool.Parse(ReadLine());
                            if (answer == true)
                            {
                                WriteLine("My guess is Kangaroo");
                            }
                            else if (answer == false)
                            {
                                WriteLine("Does it have a tail?");
                                answer = bool.Parse(ReadLine());
                                if (answer == true)
                                {
                                    WriteLine("My guess is Monkey");
                                }
                                else if (answer == false)
                                {
                                    WriteLine("My guess is Human");
                                }
                            }
                        }
                    }
                }
            ReadKey();
            Clear();
            goto Start;
                }
            }
        }