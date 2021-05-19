using System;

namespace BJ_if문
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int score = int.Parse(Console.ReadLine());
                if (score > 100 || score < 0)
                {
                    Console.WriteLine("올바른 점수를 입력하세요");
                    continue;
                }

                else if (score >= 90 && score <= 100)
                    Console.WriteLine("A");
                else if (score >= 80 && score < 90)
                    Console.WriteLine("B");
                else if (score >= 70 && score < 80)
                    Console.WriteLine("C");
                else if (score >= 60 && score < 70)
                    Console.WriteLine("D");
                else
                    Console.WriteLine("F");
                break;
            }
            


        }
    }
}
