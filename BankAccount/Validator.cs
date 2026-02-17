using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Validator
    {
        public bool IsWithinRange(double value, double min, double max)
        {
            if (value >= min)
            {
                return true;
            }
            if (value <= max)
            {
                return true;
            }
            return false;
        }
    }
}
