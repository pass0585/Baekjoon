using System;

namespace BJ_if_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int H = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            if (H < 0 || H > 24 || M < 0 || M > 59) return;

            if (M < 45)
            {
                M = M + 60;
                H = H - 1;
                if (H < 0)
                    H = 23;
                
            }
            
            Console.WriteLine("{0} {1}",H,M-45);
        }
    }
}
