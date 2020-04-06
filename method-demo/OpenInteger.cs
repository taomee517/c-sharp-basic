using System;

namespace method_demo
{
    public class OpenInteger
    {
        /// <summary>
        /// 手写int的TryParse方法
        /// </summary>
        /// <param name="val">要转为int的字符串</param>
        /// <param name="num">转化成功后的接收值</param>
        /// <returns>是否转化成功</returns>
        public bool TryParse(string val, out int num)
        {
            num = 0;
            try
            {
                num = int.Parse(val);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}不能转换为数字",val);
                return false;
            }
        }

        /// <summary>
        /// 交换两int参数的值
        /// </summary>
        /// <param name="a">参数a</param>
        /// <param name="b">参数b</param>
        public void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}