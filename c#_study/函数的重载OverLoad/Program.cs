using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048函数的重载OverLoad
{
    class Program
    {
        static int MaxNumber(params int[] intArray)
        {
            int MaxNumber = intArray[0];
            for (int i = 0; i < intArray.Length; i++)
            {
                if (MaxNumber < intArray[i])
                {
                    MaxNumber = intArray[i];
                }

            }
            return MaxNumber;
        }

        static double MaxNumber(params double[] doubleArray)
        {
            double MaxNumber = doubleArray[0];
            for (int i = 0; i < doubleArray.Length; i++)
            {
                if (MaxNumber < doubleArray[i])
                {
                    MaxNumber = doubleArray[i];
                }
            }
            return MaxNumber;
        }
        static void Main(string[] args)
        {
            int intRes = MaxNumber(12, 56, 47, 2);        //int类型的MaxNumber被调用
            double doubleRes = MaxNumber(12.33, 56.172, 47.365, 2.19);      //编译器会根据参数自动识别对应的函数去调用
            Console.WriteLine(intRes);
            Console.WriteLine(doubleRes);
            Console.ReadKey();
        }
    }
}
