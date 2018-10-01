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
            Console.WriteLine($"doubleInteger(12) => {DoubleInteger(12)}");
            Console.WriteLine($"isNumberEven(99) => {IsNumberEven(99)}");
            Console.WriteLine($"getFileExtension(\"i-miss-javascript.js\") => \"{GetFileExtension("i-miss-javscript.js")}\"");
            Console.WriteLine($"longestString([\"abc\", \"12345\", \"9\"]) => \"{LongestString(new List<string>(){"abc", "12345", "9"})}\"");
            Console.WriteLine($"arraySum([1, 2, 3, 4]) => {ArraySum(new List<int>(){1, 2, 3, 4})}");
        }

        static int DoubleInteger(int n) {
          return n * 2;
        }

        static bool IsNumberEven(int n) {
          return n % 2 == 0;
        }

        static string GetFileExtension(string filename) {
          Regex regex = new Regex(@"^.+?\.([^\.]+)$");
          Match match = regex.Match(filename);
          if (match.Success && match.Groups.Count > 1) {
            return match.Groups[1].Value;
          }
          return null;
        }

        static string LongestString(List<string> arr) {
          string ret = "";
          foreach (string item in arr) {
            if (item.Length > ret.Length) {
              ret = item;
            }
          }
          return ret;
        }

        static int ArraySum(List<int> arr) {
          int sum = 0;
          foreach (int item in arr) {
            sum += item;
          }
          return sum;
        }
    }
}
