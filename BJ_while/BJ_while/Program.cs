using System;
using System.Text;

namespace BJ_while
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int A = 1;
            int B = 1;
            StringBuilder answer = new StringBuilder();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                A = int.Parse(input[0]);
                B = int.Parse(input[1]);
                if (A == 0 || B == 0)
                    break;
                answer.Append(A + B+"\n");
            }
            Console.WriteLine(answer.ToString());
        }
    }
}
