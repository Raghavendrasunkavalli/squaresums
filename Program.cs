using System;

namespace squaresums
{
    class Program
    {
        private static void Main(string[] args)
        {
           if (squaresum())
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static bool squaresum()
        {
            Console.Write("Enter the number:");
            string c1 = Console.ReadLine();
            int c = Convert.ToInt32(c1);
            for (int a = 0; a * a <= c; a++)
            {
                for (int b = 0; b * b <= c; b++)
                {
                    if (a * a + b * b == c)
                        return true;
                }
            }
            return false;
        }
    }
}
