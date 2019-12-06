using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025GoTOContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //    while (true)
            //    {
            //        int input = Convert.ToInt32(Console.ReadLine());
            //        if (input == 0)
            //        {
            //            goto myLable;

            //        }

            //    }
            //myLable:
            //Console.WriteLine("已经跳出循环了");
            //Console.ReadLine();

            {
                while (true)
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                    {
                        return;

                    }

                }

                Console.WriteLine("已经跳出循环了");
                Console.ReadKey();
            }
        }
    }
}

