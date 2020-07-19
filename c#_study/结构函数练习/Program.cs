using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047结构函数练习
{
    //练习：使用结构体取一个坐标victor的向量值
    struct victor3
    {
        public float x;
        public float y;
        public float z;
        public double distance()
        {
            return Math.Sqrt(x * x + y * y + z * z); //Math.Sqrt用于求得一个数的根号值
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            victor3 MyVictor3;
            MyVictor3.x = 2;
            MyVictor3.y = 3;
            MyVictor3.z = 3;
            Console.WriteLine(MyVictor3.distance());
            Console.ReadKey();
        }
    }
}
