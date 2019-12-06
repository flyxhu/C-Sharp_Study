using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007OperationSelfPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            int plus1 = 100;
            plus1++;
            ++plus1;
            Console.WriteLine(plus1);
            Console.WriteLine(plus1);
            Console.WriteLine(plus1 + "||" + plus1);//202

            int plus2 = 100;
            int res1 = plus2++;
            int res2 = ++plus2;
            Console.Write(res1 + "||" + res2);//202

            int sub1 = 200;
            sub1--;
            --sub1;
            Console.WriteLine("\n",sub1);
            Console.WriteLine(sub1);
            Console.WriteLine(sub1 + "||" + sub1);

            int sub2 = 200;
            int res3 = sub2--;
            int res4 = --sub2;
            Console.WriteLine(res3 + "||" + res4);
            Console.ReadKey();
        }
    }
}
