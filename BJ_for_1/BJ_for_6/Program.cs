using System;
using System.Text;

namespace BJ_for_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            if (N>100000)
            {
                Console.WriteLine("100,000 보다 작은 수 입력");
                
            }
            else
            {
                StringBuilder Num = new StringBuilder();
                for (int i = N; i >= 1; i--)
                {
                    Num.Append(i + "\n");
                }
                Console.WriteLine(Num.ToString());
                
            }
        }
    }
}
