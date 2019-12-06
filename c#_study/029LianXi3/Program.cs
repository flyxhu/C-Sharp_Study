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

            //求出1—100的平方及平方根
            for (int j = 1; j <= 100; j++) 
            {

                int pf = j * j;
                double pfg = Math.Sqrt(j);
                Console.WriteLine("平方为：" + pf);
                Console.WriteLine("平方根为：" + pfg);

            }
            Console.ReadKey();

        }
    }
}
