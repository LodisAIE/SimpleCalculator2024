using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            bool applicationShouldClose = false;


            while (!applicationShouldClose)
            {
                Console.Clear();
                //Get input for first value
                Console.WriteLine("Input first number.");
                Console.WriteLine("Type 'q' to exit the application.");
                Console.WriteLine("Type 'c' to clear the operation.");
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                else if (input == "c")
                {
                    continue;
                }


                //Converts value to a float for later use
                float LHS = Convert.ToSingle(input);

                //Display operator options
                Console.WriteLine("Input operator:");
                Console.WriteLine("'+' - Addition");
                Console.WriteLine("'-' - Subtraction");
                Console.WriteLine("'*' - Multiplication");
                Console.WriteLine("'/' - Division");
                Console.Write("> ");
               
                //Store operator input 
                string symbol = Console.ReadLine();

                if (symbol == "q")
                {
                    break;
                }
                else if (symbol == "c")
                {
                    continue;
                }

                //Get input for second value
                Console.WriteLine("Input second number.");
                input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }
                else if (input == "c")
                {
                    continue;
                }

                //Convert input to float for later use
                float RHS = Convert.ToSingle(input);

                //Creates a new variable to store the result of the operation
                float result = 0;

                //Perform an operation based on the symbol typed
                if (symbol == "+")
                {
                    result = LHS + RHS;
                }
                else if (symbol == "-")
                {
                    result = LHS - RHS;
                }
                else if (symbol == "*")
                {
                    result = LHS * RHS;
                }
                else if (symbol == "/")
                {
                    result = LHS / RHS;
                }
                //If the user did not input a valid symbol...
                else
                {
                    //...display error message
                    Console.WriteLine("Invalid operator input.");
                }

                //Print the result of the operation
                Console.WriteLine(result);

                //Clear the screen when the player wants to proceed
                Console.ReadKey();
            }
        }
    }
}
