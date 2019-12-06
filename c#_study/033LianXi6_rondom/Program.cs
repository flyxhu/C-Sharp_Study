using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033LianXi6_rondom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num1=0, num2=0, num3=0, num4=0, num5=0, num6 = 0;
            for (int i = 0; i < 120; i++)
            {
                int num = random.Next(1, 7);
                switch (num)
                {
                    case 1:
                        num1++;
                        break;
                    case 2:
                        num2++;
                        break;
                    case 3:
                        num3++;
                        break;
                    case 4:
                        num4++;
                        break;
                    case 5:
                        num5++;
                        break;
                    case 6:
                        num6++;
                        break;

                }
            }
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.ReadKey();
        }

    }
}
