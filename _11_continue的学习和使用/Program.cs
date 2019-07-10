using System;

namespace _11_continue的学习和使用
{
    class Program
    {
        static void Main(string[] args)
        {
            #region continue的学习使用

            //while (true)
            //{
            //    Console.WriteLine("Hello world");
            //    //break;
            //    continue;
            //    Console.WriteLine("Hello world");
            //}

            //Console.ReadKey(); 

            #endregion

            #region 练习1 用while continue 实现计算1-100间所有除了不能被7整除之外的所有整数的和

            //int i = 1;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    i++;
            //    if (i % 7 == 0)
            //    {
            //        continue;
            //    }
            //    sum += i;
            //}

            //Console.WriteLine("1-100间所有除了不能被7整除之外的所有整数的和为{0}", sum);
            //Console.ReadKey();

            #endregion

            #region 练习2 找出100内所有素数

            //// 素数（又名质数）：只能被1和这个数字本身整除的数
            //// 1 不是质数，最小的质数时2

            //Console.WriteLine("1-100的质数为:");
            //for (int i = 2; i <= 100; i++)    // 遍历从2-100的所有数
            //{
            //    bool flag = true;
            //    int num = i / 2;
            //    for (int j = 2; j <= num + 1; j++)   // 判断当前循环数是不是质数
            //    {
            //        // 除尽了，说明不是质数，也就不用向下判断了
            //        if (i % j == 0)
            //        {
            //            flag = false;
            //            break;
            //        }
            //    }

            //    if (flag)
            //    {
            //        Console.Write("{0} ", i);
            //    }
            //}


            #endregion
        }
    }
}
