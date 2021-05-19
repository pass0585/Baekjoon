using System;

namespace ConsoleApp1
{
    class Program
    {
        // 곱셈 백준2588
        static void Main(string[] args)
        {
            string a1 = Console.ReadLine(); // 1번째 줄
            string a2 = Console.ReadLine(); // 2번째 줄
            char[] a3 = a2.ToCharArray();

            int num1 = int.Parse(a1);
            int[] num2 = new int[a3.Length];

            for (int i = 0; i < a3.Length; i++)
            {
                num2[i] = int.Parse(a3[i].ToString());
            }

            Console.WriteLine(num1 * num2[2]); //3번째 줄
            Console.WriteLine(num1 * num2[1]); //4번째 줄
            Console.WriteLine(num1 * num2[0]); //5번째 줄
            Console.WriteLine(num1 * num2[2]
                              + num1 * num2[1] * 10
                              + num1 * num2[0] * 100); //6번째 줄
        }
        // 한줄에 두개 입력받아 연산
        static void Main1(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            int C = int.Parse(s[2]);
            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A*B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);

        }
    }
}

