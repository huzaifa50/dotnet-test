using System;
using System.Linq;

namespace MyApp
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string input)
        {
            input = input.ToLower().Replace(" ", string.Empty).Replace(",", string.Empty).Replace(":", string.Empty);
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
