using System;

namespace BJ_if_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ( x > 1000 || x < -1000 ||
                y > 1000 || y < -1000 ||
                x == 0 || y == 0)
                    { Console.WriteLine("올바른 수를 입력하세요"); }
            else if (x > 0)
            {
                if ( y>0)
                    Console.WriteLine("1");
                else
                    Console.WriteLine("4");
            }
            else
            {
                if (y > 0)
                    Console.WriteLine("2");
                else
                    Console.WriteLine("3");
            }
        }
    }
}
