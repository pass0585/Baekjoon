using System;

namespace BJ_array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ");
            int[] Num = Array.ConvertAll(input, int.Parse);
            int Max = Num[0];
            int Min = Num[0];
            for (int i = 0; i < N; i++)
            {
               

                if (Max < Num[i])
                    Max = Num[i];
                if (Min > Num[i])
                    Min = Num[i];
            }
            Console.WriteLine("{0} {1}",Min,Max);
            
        }
    }
}
