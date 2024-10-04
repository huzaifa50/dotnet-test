using System;
using System.Linq;

namespace MyApp
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var left = 0;
            var right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
