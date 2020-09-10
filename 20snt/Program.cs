using System;

namespace _20snt
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 20;
            Console.Write($"{n} so nguyen to dau tien la :");
            daySNT(n);
            Console.ReadLine();
        }
        static void daySNT(int n)
        {
            int index = 0;
            for (int i = 2; i < 200; i++)
            {
                bool check = true;
                for (int count = 2; count <= Math.Sqrt(i); count++)
                {
                    if (i % count == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    index = index + 1;
                    if (index <= n)
                    {
                        Console.Write($"{i} ,");
                    }
                }
            }
        }
    }
}
