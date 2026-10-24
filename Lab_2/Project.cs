using System;

namespace Lab2
{
    class Program
    {
        public static int ToMultiplicate(int x, int n = 2)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += x;
            }
            return sum;
        }

        public static double ToMultiplicate(double x, int n = 2)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += x;
            }
            return sum;
        }

        public static string ToMultiplicate(string x, int n = 2)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += x;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToMultiplicate(5, 3));
            Console.WriteLine(ToMultiplicate(5));
            
            Console.WriteLine(ToMultiplicate(2.5, 4));
            Console.WriteLine(ToMultiplicate(3.1));
            
            Console.WriteLine(ToMultiplicate("abc", 3));
            Console.WriteLine(ToMultiplicate("test"));
        }
    }
}
