using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A6_WF
{
    /// <summary>
    /// Holds input validation methods.
    /// </summary>
    public class ValidateInput
    {
        /// <summary>
        /// Checks that a string is not null/whitespace and within 50 char length.
        /// </summary>
        /// <param name="input">The string to be validated</param>
        /// <returns>True if valid : False if not</returns>
        public static bool ValidateToDo(string input)
        {
            if (string.IsNullOrWhiteSpace(input)
                || input.Length > 50)
            {
                return false;
            }

            return true;
        }
    }
}
