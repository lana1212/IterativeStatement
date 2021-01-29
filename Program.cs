using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer between 1 and 100: ");
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + "." + "This is the current integer value in the loop: " + i.ToString()); 
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100.");
                    Console.WriteLine("Press any key to exit the program and try again.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer between 1 and 100.");
                Console.WriteLine("Press any key to exit the program and try again.");
                
            }
        }
    }
}
