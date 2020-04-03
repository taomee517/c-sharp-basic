namespace console_demo
{
    public class MathCalculator
    {
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