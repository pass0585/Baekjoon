using System;
using System.Text;

namespace BJ_for_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder answer = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                string[] Num = Console.ReadLine().Split();
                int A = int.Parse(Num[0]);
                int B = int.Parse(Num[1]);
                answer.Append($"Case #{i+1}: {A + B}\n");

            }

            Console.WriteLine(answer.ToString());
        }
    }
}
