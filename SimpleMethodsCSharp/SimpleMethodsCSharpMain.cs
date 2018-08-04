using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethodsCSharp
{
    class SimpleMethodsCSharpMain
    {
        public static void Main(String[] args)
        {
            SimpleMethodsCSharpTest testMethods = new SimpleMethodsCSharpTest();
            int[] testValues = { 1, 1, 1, 3, 7, 11, 7 };
            int[] testValues1 = { 1, 3, 3, 5, 7 };
            int[] testValues2 = { -1, 0, 1 };
            int[] testValues3 = { -2, -2, -1, 0, 1, 0, -1 };
            String testValues4 = "Hello World";
            String testValues5 = "mom";
            String testValues6 = "redivider";
            List<int> test = testMethods.NonDupNumbers(testValues);
            List<int> test1 = testMethods.NonDupNumbers(testValues1);
            List<int> test2 = testMethods.NonDupNumbers(testValues2);
            List<int> test3 = testMethods.NonDupNumbers(testValues3);
            List<char> test4 = testMethods.NonDupLetters(testValues4);
            int test5 = testMethods.TotalASCIIValueOfAString(testValues4);
            bool test6 = testMethods.IsPalindrome(testValues4);
            bool test7 = testMethods.IsPalindrome(testValues5);
            bool test8 = testMethods.IsPalindrome(testValues6);
            Console.Write("For the integer array: ");
            foreach(int num in testValues)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Write("The output from the method to find all non duplicated numbers is: ");
            foreach(int num in test)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Write("For the integer array: ");
            foreach (int num in testValues1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Write("The output from the method to find all non duplicated numbers is: ");
            foreach (int num in test1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Write("For the integer array: ");
            foreach (int num in testValues2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Write("The output from the method to find all non duplicated numbers is: ");
            foreach (int num in test2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Write("For the integer array: ");
            foreach (int num in testValues3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.Write("The output from the method to find all non duplicated numbers is: ");
            foreach (int num in test3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("For the string: " + testValues4);
            Console.Write("The output from the method to find all non duplicated letter is: ");
            foreach(char let in test4)
            {
                Console.Write(let + " ");
            }
            Console.WriteLine();
            Console.WriteLine("For the string: " + testValues4);
            Console.Write("The output from the method to find the total ASCII value of the string is: ");
            Console.WriteLine(test5);
            Console.WriteLine("Is " + testValues4 + " a palindrome? " + test6);
            Console.WriteLine("Is " + testValues5 + " a palindrome? " + test7);
            Console.WriteLine("Is " + testValues6 + " a palindrome? " + test8);
            Console.WriteLine("Press the enter key to exit!!!");
            Console.Read();

        }
    }
}
