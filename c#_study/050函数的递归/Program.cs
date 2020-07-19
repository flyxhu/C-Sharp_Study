using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050函数的递归
{
    class Program
    {
        static int f(int n)
        {
            if (n == 2) return 3;
            if (n == 1) return 2;            // 递归需要加上终止的条件   
            return f(n - 1) + f(n - 2);     //函数自身调用自身叫做递归
            
        }

        static void Main(string[] args)
        {
            int res1 = f(40);
            int res2 = f(1) + f(2);
            Console.WriteLine(res2);
            Console.WriteLine(res1+res2);
            //Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}
