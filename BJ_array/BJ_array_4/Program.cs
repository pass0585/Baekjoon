using System;

namespace BJ_array_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B = 42;
            int[] stack = new int[42];
            int i = 0;
            int Num = 0;
            while (true)
            {
                A = int.Parse(Console.ReadLine());
                stack[A % B]++;
                i++;

                if (i == 10)
                    break;
            }
            for (int j  = 0; j < stack.Length; j++)
            {
                if (stack[j] != 0)
                {
                    Num++;
                }
            }
            Console.WriteLine(Num);
        }
    }
}
