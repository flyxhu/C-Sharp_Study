using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using _057类的定义和使用2;

namespace _058构造函数
{
    class Vector3
    {
        // 构造函数就是用于初始化数据的函数
        private float x, y, z;
        public Vector3() 
        {
            Console.WriteLine("执行到这里，Vector3构造函数就被调用了");
        }
        public Vector3(float x,float y,float z) 
        {
            this.x = x;
            this.y = y;
            this.z = z;
            //this.Lenth = lenth();
        }
        //private float x, y, z;
        public float lenth() 
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
   

    }
}
