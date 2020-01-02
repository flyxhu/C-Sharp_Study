using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037结构体
{
    //结构体
    struct Position 
    {
        public float X;
        public float Y;
        public float Z;
    }
    //枚举值
    enum Direction 
    {
        West,
        East,
        North,
        South
    }

    struct Path
    {
        public float distance;
        public Direction dir;
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            //定义一个向量x,y,z，比较麻烦。这时我们需要使用结构体
            //不使用结构体的情况
            //float enemy1X = 34;
            //float enemy1Y = 66;
            //float enemy1Z = 102;

            //float enemy2X = 34;
            //float enemy2Y = 66;
            //float enemy2Z = 102;

            //当使用结构体时，相当于使用结构体中所有变量去声明
            //Position enemy1Position;
            //enemy1Position.X = 34;
            //Position enemy2Position;
            //enemy2Position.Y = 57;
            Path path1;
            path1.dir = Direction.East;
            path1.distance = 76;

            Path path2;
            path2.dir = Direction.South;
            path2.distance = 101;

          }
    }
}
