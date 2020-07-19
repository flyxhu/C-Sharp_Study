using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045参数数组
{
    class Program
    {
        static int Plus(int[] array)         //对不确定参数个数的数组进行求和,（数组参数）
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //int sum = 0;
                sum += array[i];            //sum +=array[i]相当于sum = sum + array[i]
                                             
            }
            return sum;
        }

        static int Multiply(int[] array2)
        {
            int multiple = 1;
            for (int i = 0; i < array2.Length; i++)
            {
                multiple *= array2[i];     //multiples =multiples * array2[i];

            }

            return multiple;

        }

        static int Multiplys(params int[] array3)       //定义参数数组的函数，在参数类型（int）前面加上params，
                                                        //调用的时候编译器会自动生成一个int类型的数组，而数组参数是需要自己传参的时候构造一个数组
        {
            int multiples = 1;
            for (int i = 0; i < array3.Length; i++)
            {
                multiples *= array3[i];
            }
            return multiples;

        }

        static void Main(string[] args)
        {
            int sum = Plus(new int[] { 12, 3, 56, 8, 12 });
            int mutiple = Multiply(new int[] { 1, 3, 5, 7, 9 });

            //int mutiples = Multiply(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            int mutiples = Multiplys(1,1,1,1,1,1, 3, 5, 7, 9, 11);

            Console.WriteLine(sum);
            Console.WriteLine(mutiple);
            Console.WriteLine(mutiples);
            Console.ReadKey();

        }
    }
}
