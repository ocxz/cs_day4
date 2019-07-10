using System;

namespace _05_for循环的嵌套
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 当遇到某个事要做一遍时另外一个事要做N遍，此时就要用到for循环嵌套
            //// 当遇到某个事要做一遍时另外一个事要做N遍，此时就要用到for循环嵌套

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine("Hello World i循环了{0}次，j循环了{1}次", i, j);
            //        break;
            //    }
            //}

            //Console.ReadKey(); 
            #endregion

            #region for循环嵌套，实现乘法口诀表

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        if (j > i)
            //        {
            //            break;    // 只打印半张表，j>i部分跳过循环
            //        }
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);   // 格式输出
            //    }
            //    Console.WriteLine();   // 换行
            //}
            //Console.ReadKey(); 

            #endregion

            #region for循环嵌套，实现乘法口诀表2

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)   // 打印半张，不考虑j>i的情况
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);   // 格式输出
            //    }
            //    Console.WriteLine();   // 换行
            //}

            //Console.ReadKey();

            #endregion

            #region for循环（单层循环）实现加法表
            //// 让用户输入一个数，显示下面内容  
            //// 请输入一个值：6
            //// 根据这个值可以输出以下加法表：
            //// 0 + 6 = 6
            //// 1 + 5 = 6
            //// 2 + 3 = 6
            //// 3 + 3 = 6
            //// 4 + 2 = 6
            //// 5 + 1 = 6
            //// 6 + 0 = 6

            //Console.Write("请输入一个值(正整数）：");
            //int number = 0;

            //// 确保输入的是正整数，否则一直要求输入
            //while (true)
            //{
            //    try
            //    {
            //        number = Convert.ToInt32(Console.ReadLine());
            //        break;
            //    }
            //    catch
            //    {
            //        Console.Write("输入错误，请重新输入一个值(正整数）：");
            //    }
            //}

            //Console.WriteLine("根据这个值可以输出如下加法表");

            //for (int i = 0; i <= number; i++)
            //{
            //    Console.WriteLine("{0} + {1}\t= {2}", i, number - i, number);   // 格式化输出
            //}

            //Console.ReadKey();
            #endregion

        }
    }
}
