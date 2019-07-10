using System;

namespace _12_随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 用Random对象的Next()方法产生随机数
            //// 产生随机数
            //// 1、创建能够产生随机数的对象
            //Random r = new Random();
            //while (true)
            //{
            //    // 2、调用产生随机数的方法
            //    int rNumber = r.Next(1, 11);   // 左闭右开取值

            //    Console.WriteLine(rNumber);
            //    Console.ReadKey();
            //} 
            #endregion

            #region  输入名字，随机显示这个人上辈子是什么样的人（用Random对象）
            ///* 
            // * 输入名字，随机显示这个人上辈子是什么样的人（用Random对象）
            // * 思路：
            // * 1、创建能够产生随机数的对象 Random r = new Random();
            // * 2、产生随机数（1-7）
            // * 3、利用switch-case分配
            // */

            //Random r = new Random();
            //while (true)
            //{
            //    int rNumber = r.Next(1, 7);

            //    Console.WriteLine("请输入一个姓名");
            //    string name = Console.ReadLine();
            //    switch (rNumber)
            //    {
            //        case 1:
            //            Console.WriteLine("{0}上辈子是吃翔的", name);
            //            break;
            //        case 2:
            //            Console.WriteLine("{0}上辈子是拉翔的", name);
            //            break;
            //        case 3:
            //            Console.WriteLine("{0}上辈子是一坨翔", name);
            //            break;
            //        case 4:
            //            Console.WriteLine("{0}上辈子是大汉奸", name);
            //            break;
            //        case 5:
            //            Console.WriteLine("{0}上辈子是拉皮条的", name);
            //            break;
            //        case 6:
            //            Console.WriteLine("{0}上辈子是救苦救难的活菩萨", name);
            //            break;

            //    }
            //    Console.ReadKey();
            //} 
            #endregion

        }
    }
}
