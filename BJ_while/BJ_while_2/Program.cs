using System;

namespace BJ_while
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string num = Console.ReadLine();
                if (num == null)
                { break; }
                string[] input = num.Split();
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);
                Console.WriteLine(A + B);

                
            }
            
        }
    }
}
