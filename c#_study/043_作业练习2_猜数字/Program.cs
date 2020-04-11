using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043_作业练习2_猜数字
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习2：猜数，输入一个数，用户输入一个0—50之间的数：20，您猜小了，这个数比20大；
            // 30，你猜大了，这个数比30小；25，恭喜您猜对了
            //low:
            //Console.WriteLine("请您输入一个0-50之间的数字:");
            //byte isResult = Convert.ToByte(Console.ReadLine());
            //switch (isResult)
            //{
            //    case 20:
            //        Console.WriteLine("您猜小了，这个数比20大");
            //        break;
            //    case 30:
            //        Console.WriteLine("您猜打了，这个数比20大");
            //        break;
            //    case 25:
            //        Console.WriteLine("您猜对了，这个数就是25");
            //        break;
            //}

            // high bega
            Console.WriteLine("请输入一个0-50之间的数");
            byte isResult_1 = Convert.ToByte(Console.ReadLine());
            if (isResult_1 >= 0 && isResult_1 <= 50)
            {
                if (isResult_1 >= 0 && isResult_1 <= 20)
                {
                    Console.WriteLine("您猜小了，这个数比20还要大哦！");
                }
                else if (isResult_1 >= 30 && isResult_1 <= 50)
                {
                    Console.WriteLine("您猜大了，这个数比30还要小哦！");
                }
                else if (isResult_1 == 25)
                {
                    Console.WriteLine("您猜对了，这个数就是25.");
                }
                // else if (isResult_1 > 20 && isResult_1 < 30 && isResult_1 != 25) ;
                else
                    Console.WriteLine("您快猜对了，已经很接近这个数了哦！");
            }
            else
                Console.WriteLine("您输入的数字不合法，请重新输入！");
            Console.ReadKey();
        }
    }
}
