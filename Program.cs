//Author: Liam Kelly
//Date: 9/11/2020
//Description: This is the tech project @2a

using System;

namespace TechProj2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Integer value between 1 and 25 to execute an iterative statement: ");
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times.");
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program!");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Make sure you enter an integer between 1 and 25 and try again!");
                    Console.WriteLine("Press any key to exit the program and try again!");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again!");
                Console.WriteLine("Press any key to exit the program!");
                Console.ReadKey(true);
            }
        }
    }
}
