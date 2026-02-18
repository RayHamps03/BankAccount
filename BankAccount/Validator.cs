using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Validator
    {
        /// <summary>
        /// Determines whether a specified value falls within the inclusive range defined by the given minimum and
        /// maximum values.
        /// </summary>
        /// <param name="value">The value to test for inclusion within the specified range.</param>
        /// <param name="min">The inclusive lower bound of the range.</param>
        /// <param name="max">The inclusive upper bound of the range.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Thrown if min is greater than max.</exception>
        public bool IsWithinRange(double value, double min, double max)
        {
            if (min > max)
            {
                throw new ArgumentException("Minimum cannot be greater than the maximum.");
            }

            if (value >= min && value <= max)
            {
                return true;
            }
            return false;
        }
    }
}
