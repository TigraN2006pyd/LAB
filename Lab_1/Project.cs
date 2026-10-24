using System;

namespace Lab1
{
    class Matrix
    {
        private int n;
        private int a;
        private int b;
        private int[,] m;

        public int N 
        { 
            get => n; 
            set => n = value; 
        }
        
        public int A 
        { 
            get => a; 
            set => a = value; 
        }
        
        public int B 
        { 
            get => b; 
            set => b = value; 
        }

        public Matrix(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;
            m = new int[N, N];
            FillMatrix();
        }

        private void FillMatrix()
        {
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    m[i, j] = rnd.Next(A, B + 1);
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int GetOddCount()
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (m[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrix mat = new Matrix(3, 1, 10);
            mat.ShowMatrix();
            Console.WriteLine(mat.GetOddCount());
        }
    }
}
