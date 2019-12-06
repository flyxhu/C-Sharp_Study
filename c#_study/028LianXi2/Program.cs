using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028LianXi2
{
    class Program
    {
        static void Main(string[] args)
        {
            //用户输入一个整数，求出这个整数的平方和平方根，并且输入的整数小于等于100时才有效
            Console.WriteLine("请输入一个整数");
            int j = Convert.ToInt32(Console.ReadLine());
                if (j <= 1000)
                {

                    int pf = j * j;
                    double pfg = Math.Sqrt(j);
                    j += 1;
                    Console.WriteLine("这个数的平方为："+ pf);
                    Console.WriteLine("这个数的平方根为："+ pfg);
                
                }
                else
                {
                Console.WriteLine("您输入的值大于1000无效");
                }
            Console.ReadKey();

        }
    }
}
