using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UnderPressure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Under Pressure Challenges:\n");
            Console.WriteLine($"doubleInteger(12) => {doubleInteger(12)}");
            Console.WriteLine($"isNumberEven(99) => {isNumberEven(99)}");
            Console.WriteLine($"getFileExtension(\"i-miss-javascript.js\") => \"{getFileExtension("i-miss-javscript.js")}\"");
            Console.WriteLine($"longestString([\"abc\", \"12345\", \"9\"]) => \"{longestString(new List<string>(){"abc", "12345", "9"})}\"");
            Console.WriteLine($"arraySum([1, 2, 3, 4]) => {arraySum(new List<int>(){1, 2, 3, 4})}");
        }

        static int doubleInteger(int n) {
          return n * 2;
        }

        static bool isNumberEven(int n) {
          return n % 2 == 0;
        }

        static string getFileExtension(string filename) {
          Regex regex = new Regex(@"^.+?\.([^\.]+)$");
          Match match = regex.Match(filename);
          if (match.Success && match.Groups.Count > 1) {
            return match.Groups[1].Value;
          }
          return null;
        }

        static string longestString(List<string> arr) {
          string ret = "";
          foreach (string item in arr) {
            if (item.Length > ret.Length) {
              ret = item;
            }
          }
          return ret;
        }

        static int arraySum(List<int> arr) {
          int sum = 0;
          foreach (int item in arr) {
            sum += item;
          }
          return sum;
        }
    }
}
