using System;

namespace Lab4
{
    class Program
    {
        public static void A(in int x)
        {
            Console.WriteLine(x);
        }

        public static void B(out int x)
        {
            x = 10;
        }

        public static void C(ref int x)
        {
            x += 5;
        }

        public static int SumValues(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int a = 5;
            A(in a);

            int b;
            B(out b);
            Console.WriteLine(b);

            int c = 10;
            C(ref c);
            Console.WriteLine(c);

            int total = SumValues(1, 2, 3, 4, 5);
            Console.WriteLine(total);
        }
    }
}
