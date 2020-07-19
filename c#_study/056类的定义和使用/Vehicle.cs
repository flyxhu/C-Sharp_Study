using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056类的定义和使用
{
    class Vehicle
    {
        public float speed;
        public float maxSpeed;
        public float weight;

        public void Run()
        {
            Console.WriteLine("这个车正在以" + speed + "km/s速度行驶");
        }

        public void Stop()
        {
            speed = 0;
            Console.WriteLine("车辆停止行驶");
        }
    }
}
