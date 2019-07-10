using System;

namespace _04_for循环小练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for循环实现，求1-100所有偶数和

            //int sum = 0;
            //for (int i = 2; i <= 100; i += 2)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("1-100所有偶数和为{0}", sum);
            //Console.ReadKey();

            #endregion

            #region for循环实现，求1-100所有整数和，偶数和，奇数和

            //int sum = 0;        // 声明一个变量，用来存储整数和
            //int evenSum = 0;    // 声明一个变量，用来存储偶数和
            //int oddSum = 0;    // 声明一个变量，用来存储奇数和

            //for (int i = 1; i <= 100; i++)
            //{
            //    sum += i;
            //    if (i % 2 == 0)   // 如果i为偶数
            //    {
            //        evenSum += i;
            //    }
            //    else    // i为奇数
            //    {
            //        oddSum += i;
            //    }   
            //}

            //Console.WriteLine("1-100所有整数和为{0}，所有偶数和为{1}，所有奇数和为{2}", sum, evenSum, oddSum);
            //Console.ReadKey();

            #endregion

            #region for循环实现，找出100-999间的水仙花数

            //// 水仙花数：百位数字，百位的立方+十位的立方+个位的立方==该数

            //for (int i = 100; i < 1000; i++)
            //{
            //    int h = (i % 1000) / 100;       // 该数的百位
            //    int t = (i % 100) / 10;   // 该数的十位
            //    int u = (i % 10) / 1;   // 该数的个位

            //    if (i == (h * h * h + t * t * t + u * u * u))
            //    {
            //        Console.WriteLine("{0}是水仙花数，它的百位是{1}，十位是{2}，个位是{3}", i, h, t, u);
            //    }
            //}

            //Console.ReadKey();

            #endregion
        }
    }
}
