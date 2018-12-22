using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTTesting
{
    /// <summary>
    /// A collection of mathematical functions
    /// </summary>
    public static partial class Math
    {
        /// <summary>
        /// Calculates the factorial
        /// </summary>
        /// <param name="number">Input</param>
        /// <returns>Factorial of input</returns>
        public static int Factorial(int number)
        {
            if(number < 0 || number > 12) { return -1; }
            else if(number <= 1) { return 1; }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        /// <summary>
        /// Calculates the sum of all the numbers up to and including the given number
        /// </summary>
        /// <returns>The Sum</returns>
        public static int Sigma(int number)
        {
            if (number < 0)
            {
                return -1;
            }
            else if (number == 0)
            {
                return 0;
            }
            else
            {
                return number + Sigma(number - 1);
            }
        }
    }
}
