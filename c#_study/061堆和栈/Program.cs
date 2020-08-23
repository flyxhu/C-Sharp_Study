using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _061堆和栈
{
    class Program
    {
        static void Main(string[] args)
        {
            //堆和栈的特征
            //1.堆：空间大，但是速度慢
            //2.栈：空间小，但是速度快
            //3.入栈：只能从栈顶中入，出栈：也只能从栈顶出（栈顶的对象需要先出，底部的才能出栈）

            //变量的存储
            //1.值类型和引用类型
            //(1)值类型：int、bool、struct、char、小数：需要一个单独的内存，用来存储实际的数据，放在栈中
            //(2)引用类型：string、数组、自定义的类、内置的类
            // --- 引用类型：需要两段内存：一段用来存储实际的数据，总是放在堆中；第二段是一个引用，指向数据在堆中的位置(存放在栈中)

            //!!!当一个数组的引用类型就是一个值时，那队中存储的就是值；
            //!!!当一个数组的引用类型是一个引用类型（如还是一个数组），则堆里面会先存储内存地址，内存地址再指向存储实际的值。
        }
    }
}
