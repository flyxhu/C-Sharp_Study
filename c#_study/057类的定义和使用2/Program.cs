using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057类的定义和使用2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 vector = new Vector3();

            //vector.x = 1;
            //vector.y = 1;
            //vector.z = 1;

            vector.SetX(0);
            vector.SetY(3);
            vector.SetZ(4);

            Console.WriteLine(vector.Length());
            Console.ReadKey();
        }
    }
}
