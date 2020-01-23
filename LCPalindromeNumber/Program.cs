using System;
using System.Linq;

namespace LCPalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1001;

            Console.WriteLine(CheckPalindrome(x));

            bool CheckPalindrome(int number)
            {
                var numberString = number.ToString();

                int stringLength = numberString.Length;

                var firstHalf  = string.Empty;
                var secondHalf = string.Empty;

                if( stringLength % 2 == 0)
                {
                    firstHalf  = numberString.Substring(0, stringLength / 2);
                    secondHalf = numberString.Substring(stringLength / 2);
                }
                else
                {
                    firstHalf  = numberString.Substring(0, stringLength / 2);
                    secondHalf = numberString.Substring((stringLength / 2) + 1);
                }

                var mirroredHalf = string.Concat(secondHalf.Reverse());

                return (firstHalf.Equals(mirroredHalf));
            }
        }
    }
}
