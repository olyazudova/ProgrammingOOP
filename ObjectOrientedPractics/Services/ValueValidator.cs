using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Implements statistical data validation.
    /// </summary>
    static class ValueValidator
    {

        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} ожидается, что он будет меньше чем {maxLength}");
            }
        }



        public static void AssertStringOnLength(double value, int minLength, int maxLength, string propertyName)
        {
            if (value < minLength || value > maxLength)
            {
                throw new ArgumentException($"{propertyName} ожидается, что он будет меньше чем {minLength} и больше чем {maxLength}");
            }
        }

    }
}