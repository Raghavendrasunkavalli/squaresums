using System;

namespace squaresums
{
    class Program
    {
        private static void Main(string[] args)
        {
           if (squaresum()) //Calling Squaresum method in the main method for execution.
                // if the square sum method returns a value of true, the below messages is displayed to user
            {
                Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
            }
            else // if the square sum method returns a value of False, the below messages is displayed to user
            {
                Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
            }
        }
        static bool squaresum() //New method to find the squaresum solution
        {
            try
            {
                Console.Write("Q3 : Enter the number to check if squareSums exist:");//Display message for the user input.
                string c1 = Console.ReadLine(); // Reading the user Input.
                int c = Convert.ToInt32(c1); // Convert the string type to integer.
                for (int a = 0; a * a <= c; a++) // Initializing for loop to iterate upto c to avoid index out of bond exception.
                {
                    for (int b = 0; b * b <= c; b++) //Initializing for loop to check for the first number in the two numbers
                    {
                        if (a * a + b * b == c) // Checking the condition.
                            return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
