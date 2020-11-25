using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public static class Validator
    {

        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            string pattern = @"^(\d{3})([\s-]?)(\d{2})([\s-]?)(\d{4})$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(ssn);
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            return numToTest >= minValue && numToTest <= maxValue;
        }
    }
}
