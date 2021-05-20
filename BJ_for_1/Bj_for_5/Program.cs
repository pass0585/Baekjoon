using System;
using System.Text;

namespace Bj_for_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder Num = new StringBuilder();
            
            for (int i = 1; i <= N; i++)
            {
                Num.Append(i + "\n");
            }
            Console.WriteLine(Num.ToString());
        }
    }
}
