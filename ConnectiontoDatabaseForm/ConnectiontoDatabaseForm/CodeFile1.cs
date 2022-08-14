using System;
using System.Text.RegularExpressions;

namespace ConnectiontoDatabaseForm

{
    class Numbers
    {
        static void digits()
        {
            string input = "123456789";
            bool isValid = Regex.IsMatch(input, @"^\d{9}$");
            Console.Write("Input number: ", input);
        }
    }

    class TakeNumbers
    {
        static int concat(int a, int b)
        {
            String s1 = a.ToString();
            String s2 = b.ToString();

            String s = s1 + s2;

            int c = int.Parse(s);

            return c;
        }

        public static void main(String []args)
        {
            int a = 14;
            int b = 96;

            Console.WriteLine(concat(a, b));
        }
    }

    class Descending
    {
        public static object a { get; private set; }

        public static string number(string []arr)
        {
            object[] arr = new[] { a, b, c };
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.Write("Input numbers: ", arr);
            Console.WriteLine("{0}, {1}, {2}", arr[0], arr[1], arr[2]);
        }
          
    }
}