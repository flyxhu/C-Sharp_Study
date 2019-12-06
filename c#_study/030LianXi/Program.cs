using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030LianXi4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    Console.WriteLine(i);
                    count += 1;

                }

            }
            Console.WriteLine("这样的i共有：" + count + "个");
            Console.ReadKey();

        }
    }    
}
