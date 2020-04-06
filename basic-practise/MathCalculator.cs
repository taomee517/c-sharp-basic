namespace console_demo
{
    public class MathCalculator
    {
        /// <summary>
        /// 求num的阶乘
        /// 如num=3
        /// 返回 3*2*1=6;
        /// </summary>
        /// <param name="num"></param>
        /// <returns>int</returns>
        public int CalFactorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }

            var fa = CalFactorial(num - 1) * num;
            return fa;
        }
    }
}