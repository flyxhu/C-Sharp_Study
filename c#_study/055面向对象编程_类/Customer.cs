using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055面向对象编程_类
{
    class Customer   //这里我们定义了新的类，叫做Customer类
    {
        //数据成员：里面包含了四个字段
        public string name;
        public int age;
        public int customerID;
        public string address;
        public string buyTime;

        //函数成员：定义了一个Show函数
        public void Show()
        {
            Console.WriteLine("顾客名字：" + name);
            Console.WriteLine("顾客年龄：" + age);
            Console.WriteLine("顾客编号：" + customerID);
            Console.WriteLine("顾客地址：" + address);
            Console.WriteLine("顾客上一次消费时间：" + buyTime);
        }

    }
}
