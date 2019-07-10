using System;

namespace _10_for循环的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1 循环录入5人年龄算平均，录入年龄为负数或超出100停止输入并报错

            //int sum = 0;
            //bool flag = true;
            //for (int i = 0; i < 5; i++)
            //{
            //    try
            //    {
            //        Console.WriteLine("请输入第{0}个人的年龄", i + 1);
            //        int age = Convert.ToInt32(Console.ReadLine());
            //        if (age >= 0 && age <= 100)
            //        {
            //            sum += age;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入的年龄不在正确范围内，程序退出！！！");
            //            flag = false;
            //            break;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入的你年龄不正确，程序退出！！！");
            //        flag = false;
            //        break;
            //    }
            //}

            //if (flag)
            //{
            //    Console.WriteLine("5个人的平均年龄是{0}", sum / 5);
            //}
            //Console.ReadKey();

            #endregion

            #region 利用while和break实现用户登录，用户名和密码正确，登录成功，否则一直提示登录失败并重新登录

            //string uName = "";
            //string uPwd = "";
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    uName = Console.ReadLine();
            //    Console.WriteLine("请输入用户密码");
            //    uPwd = Console.ReadLine();

            //    if (uName == "admin" && uPwd == "password")
            //    {
            //        Console.WriteLine("恭喜您，登录成功");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或密码不正确，请重新输入");
            //    }
            //}

            //Console.ReadKey();

            #endregion

            #region 1-100之间整数相加，得累计值大于20的当前数（如：1+2+3+4+5+6=21  得6 因为当加到6时sum>20)

            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum += i;
            //    if (sum >= 20)
            //    {
            //        Console.WriteLine("加到{0}的时候，总和大于了20", i);
            //        break;
            //    }
            //}

            //Console.ReadKey();

            #endregion
        }
    }
}
