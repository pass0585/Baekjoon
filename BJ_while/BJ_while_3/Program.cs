using System;

namespace BJ_while_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());  // 숫자 받기
            int F;              // 10의 자리 수
            int B;              // 1의 자리 수
            int New_num = N;    
            int cycle = 0;      // 싸이클
            
            
            while(true)
            {
                F = New_num / 10;
                B = New_num % 10;
                int sum = F + B;    // 앞 뒤 숫자 합

                
                New_num = (B*10)+(sum%10);
                cycle++;

                if (N == New_num)
                    break;
                
            }
            Console.Write(cycle);
        }
    }
}
