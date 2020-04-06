using System;
using System.Diagnostics;

namespace login_demo
{
    /// <summary>
    /// 模拟登录操作
    /// 如果用户名和密码都输入正确，可进入主页
    /// 如果用户输错3次，则退出程序
    /// </summary>
    class Program
    {
        private const string Username = "admin";
        private const string Password = "666666";
        private const int MaxRetry = 3;
        
        
        static void Main(string[] args)
        {
            var retry = 0;
            var pwdRetry = 0;
            
            while (true)
            {
                if (retry==0)
                {
                    Console.WriteLine("请输入用户名：");
                }
                var name = Console.ReadLine();

                if (name != Username)
                {
                    retry++;
                    EnsureRetryLimit(retry);
                    Console.WriteLine("用户名不存在，请重新输入！");
                }
                else
                {
                    while (true)
                    {
                        if (pwdRetry==0)
                        {
                            Console.WriteLine("请输入密码：");
                            
                        }
                        var pwd = Console.ReadLine();

                        if (pwd == Password)
                        {
                            Console.WriteLine("登录成功！");
                            break;
                        }
                        else
                        { 
                            retry++;
                            pwdRetry++;
                            EnsureRetryLimit(retry);
                            Console.WriteLine("密码输入错误，请重新输入！");
                        }
                    }
                    break;
                }
            }
            Console.WriteLine("进入主页");
        }
        
        
        /// <summary>
        /// 确定重试次数没有超过最大值
        /// </summary>
        /// <param name="retry">重试次数</param>
        private static void EnsureRetryLimit(int retry)
        {
            if (retry >= MaxRetry)
            {
                Console.WriteLine("错误次数超过最大限制，请改天再试！");
                Process.GetCurrentProcess().Kill();
            }
        }
        
        
    }
}