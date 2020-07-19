using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044函数的递归与调用
{
    class Program
    {
        
        static int F(int n)
            {
                if (n == 0) return 2;
                if (n == 1) return 3;
                return F(n-1) + F(n-2); //函数调用自身，叫做函数的递归
            }
        static void Main(string[] args)
        {
            int result_1 = F(40);
            int result_2 = F(2);

            Console.WriteLine(result_1);
            Console.WriteLine(result_2);
            Console.ReadKey();
        }
        
    }
}
