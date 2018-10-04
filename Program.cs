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

        string indexOfAllOutput = String.Join(", ", IndexOfAll("Hello world!", "ol!e"));
        Console.WriteLine($"IndexOfAll(\"Hello world!\", \"ol!e\") => [{indexOfAllOutput}]");

        Console.WriteLine($"GCD(48, 18) => {GCD(48, 18)}");
        Console.WriteLine($"GCD(18, 48) => {GCD(18, 48)}");
    }

static int DoubleInteger(int n) => n * 2;

static bool IsNumberEven(int n) => n % 2 == 0;

static string GetFileExtension(string filename) {
      // Regex regex = new Regex(@"^.+?\.([^\.]+)$");
      // Match match = regex.Match(filename);
      // if (match.Success && match.Groups.Count > 1) {
      //   return match.Groups[1].Value;
      // }
      // return null;

      string[] arr = filename.Split('.');
      return arr.Length < 2 ? null : arr[arr.Length - 1];
    }

    static string LongestString(List<string> arr) {
      string longest = "";
      foreach (string str in arr) {
        if (str.Length > longest.Length) {
          longest = str;
        }
      }
      return longest;
    }

    static int ArraySum(List<int> arr) {
      int sum = 0;
      foreach (int num in arr) {
        sum += num;
      }
      return sum;
    }

    static List<int> IndexOfAll(string str, string toFind) {
      List<int> ret = new List<int>();
      List<char> toFindArr = new List<char>(toFind.ToCharArray());
      for (int i = 0; i < str.Length; ++i) {
        for (int j = 0; j < toFindArr.Count; ++j) {
          if (toFindArr[j] == str[i]) {
            ret.Add(i);
            toFindArr.RemoveAt(j);
          }
        }
      }
      return ret;
    }

    static int GCD(int a, int b) {
      return b == 0 ? a : GCD(b, a % b);
    }
  }
}
