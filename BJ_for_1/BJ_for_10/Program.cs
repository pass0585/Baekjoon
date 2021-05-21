using System;
using System.Text;

namespace BJ_for_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] NX = Console.ReadLine().Split(' ');
            int N = int.Parse(NX[0]);
            int X = int.Parse(NX[1]);

            StringBuilder inp = new StringBuilder(Console.ReadLine());
            string[] input = inp.ToString().Split(' ');

            StringBuilder answer = new StringBuilder();
            int[] Num = new int[N];

            for (int i = 0; i < N; i++)
            {
                Num[i] = int.Parse(input[i]);

                if (Num[i] < X)
                {
                    answer.Append(Num[i]).Append(" ");
                }
            }

            Console.WriteLine(answer.ToString());

        }
    }
}
