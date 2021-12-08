using System;
using System.Text.RegularExpressions;

namespace Test
{
    public class Test3
    {
        public static void palindrome(string sentence){
            string data = Regex.Replace(sentence.ToLower(), "\\W", String.Empty);
            if (data == ReverseString(data)){
                Console.WriteLine($"{sentence} is a Palindrome.");
            } else {
                Console.WriteLine($"{sentence} is not a Palindrome.");
            }
        }
        public static string ReverseString(string sentence)
        {
            char[] arr = sentence.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}