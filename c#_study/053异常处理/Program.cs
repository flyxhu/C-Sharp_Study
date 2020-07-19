using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myArray = { 1, 2, 3, 4, 5 };
                int myIndex = myArray[5];
            }
            //catch (NullReferenceException e)  //捕捉异常的类型与实际发生的异常类型不一致，不会执行catch块语句
            //{
            //    Console.WriteLine("这样会捕捉不到异常，因为即使程序发生了异常，但是捕捉异常的类型不对，就不会执行到这里");
            //}

            //catch                   //如果catch块不放异常类型，则默认捕捉全部的异常
            //{
            //    Console.WriteLine("执行到这里，捕捉到的异常为访问的数值下标越界了");
            //}

            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("执行到这里，已经捕捉到异常");
                Console.WriteLine("捕捉到的异常为访问的数值下标越界了");
            }

            Console.WriteLine("Test array");
            Console.ReadKey();

        }
    }
}
