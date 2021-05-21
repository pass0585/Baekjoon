using System;
using System.Text;

namespace BJ_array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int order = 0, i = 0;
            int Max = 0;
            int Num;
            
            while (true)
            {
                i++;
                Num = int.Parse(Console.ReadLine());

                if (Num > Max)
                {   
                    Max = Num;
                    order = i;
                }
                if (i == 9)
                    break;
            }

            Console.WriteLine(Max);
            Console.WriteLine(order);

        }
    }
}
