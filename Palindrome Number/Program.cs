using System;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
        }

        static bool IsPalindrome(int x)
        {
            string str = x.ToString();
            for (int i = 0, j = str.Length - 1; i <= str.Length / 2 && j >= str.Length / 2; i++, j--)
            {
                if (str[i] != str[j]) return false;
            }
            return true;
        }
    }
}
