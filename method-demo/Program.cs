using System;
using System.Text;
using for_demo;
using Microsoft.VisualBasic;

namespace method_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] {23, 134, 64, 15, 9, 98, 46};
            ArrayUtil au = new ArrayUtil();
            
            //方案一：通过一个结构来接收返回值
            ArrayInfo ai = au.CalArrayInfo(array);
            Console.WriteLine("数组的最大值是： {0}， 最小值是：{1}， 总和是：{2}， 平均值是：{3:0.00}", ai._max, ai._min, ai._sum, ai._avg);
            

            //方案二：通过out参数来接收返回值
            // int max;
            // int min;
            // int sum;
            // double avg;
            // au.GetMinMax(array,out max, out min, out sum, out avg);
            // Console.WriteLine("数组的最大值是： {0}， 最小值是：{1}， 总和是：{2}， 平均值是：{3:0.00}", max, min, sum, avg);
            
            
            // //练习： 熟悉out参数，手写TryParse方法
            // Console.WriteLine("请输入任意要转化为数字的字符串:");
            // string val = Console.ReadLine();
            // int num;
            // OpenInteger oi = new OpenInteger();
            // bool flag = oi.TryParse(val, out num);
            // Console.WriteLine("{0}转int是否成功：{1}，转化结果是：{2}", val, flag, num);
            
            
            //练习： 熟悉ref参数 去除消息的结尾字符
            string msg = "6,7#b203,ads,34194237#";
            TailTrim(ref msg);
            Console.WriteLine("去掉尾巴后的msg: {0}", msg);
            
            
            //练习： 熟悉ref参数 交换两个参数的值
            int num1 = 100;
            int num2 = 200;
            OpenInteger oi = new OpenInteger();
            oi.Swap(ref num1, ref num2);
            Console.WriteLine("num1 = {0}, num2 = {1}", num1, num2);
            
            
            //练习： 熟悉params 将时间串连起来
            string date = BuildDate("-", 2020, 4, 6);
            Console.WriteLine("拼装出来的时间是：{0}", date);
        }
        
        /// <summary>
        /// 拼装时间
        /// </summary>
        /// <param name="connector">连接符</param>
        /// <param name="dateParams">年月日数组</param>
        /// <returns></returns>
        private static string BuildDate(string connector, params int[] dateParams)
        {
            StringBuilder sb = new StringBuilder();
            int lastIndex = dateParams.Length - 1;
            for (int i = 0; i < lastIndex; i++)
            {
                int param = dateParams[i];
                sb.Append(param);
                sb.Append(connector);
            }
            sb.Append(dateParams[lastIndex]);
            return sb.ToString();
        }
        

        /// <summary>
        /// 去掉消息的结尾符号
        /// </summary>
        /// <param name="msg">原消息</param>
        private static void TailTrim(ref string msg)
        {
            if (msg.EndsWith("#"))
            {
                msg = msg.Substring(0, msg.Length - 1);
            }
        }
    }
}