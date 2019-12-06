using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022WhileXunhuan
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            while (index <= 10)
            {

                Console.WriteLine(index);
                //index++;
                ++index;
            }
            Console.ReadKey();
        }
    }
}
