using System;

namespace _09_类型转换_str转其他_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 

            ////方法一 Convert转换  注意点：面上一定要过得去  失败抛异常  内部调用的还是 类型.Parse
            //int numberOne = Convert.ToInt32("123");
            //Console.WriteLine(numberOne);
            //Console.ReadKey();

            //// 方法二 类型.Parse  使用与Convert一样
            //int numberTwo = int.Parse("456abc");
            //Console.WriteLine(numberTwo);
            //Console.ReadKey();

            //// 方法三 类型.TryParse(str,out int)  
            //// 转换成功：将转换的值赋给num，返回true
            //// 转换失败：将0赋给num，返回false
            //// 不抛出异常
            //int num = 1;
            //bool b = int.TryParse("123abc", out num);
            //Console.WriteLine("转换结果：{0},转换顺利否？{1}", num, b);
            //Console.ReadKey();


            #endregion
        }
    }
}
