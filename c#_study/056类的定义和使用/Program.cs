using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056类的定义和使用
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle();
            vehicle1.speed = 106;

            vehicle1.Run();
            vehicle1.Stop();
            Console.WriteLine("车辆现在的速度：" + vehicle1.speed + "km/s");
            Console.ReadKey();
        }
    }
}
