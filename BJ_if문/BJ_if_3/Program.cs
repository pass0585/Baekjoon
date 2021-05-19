using System;

namespace BJ_if_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int Year = int.Parse(Console.ReadLine());
                if (Year < 1 || Year > 4000)
                {
                    Console.WriteLine("올바른 연도를 입력하세요");
                    continue;
                }

                else if (Year % 4 == 0)
                {
                    if (Year % 400 == 0)
                        Console.WriteLine("1");
                    else if (Year % 100 != 0)
                        Console.WriteLine("1");
                    else
                        Console.WriteLine("0");
                }
               
                else
                    Console.WriteLine("0");
                break;
            }
        }
    }
}
