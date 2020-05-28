using System;

namespace delegate_demo.methods
{
    public static class TransformMethods
    {
        public static int Square(int x)
        {
            Console.WriteLine("进入平方方法");
            return x * x;
        }

        public static int Double(int x)
        {
            Console.WriteLine("进入2倍方法");
            return 2 * x;
        }
        
        public static void ShowSquare(int x)
        {
            var temp =  x * x;
            Console.WriteLine("进入平方方法：result = {0}",temp);
        }

        public static void ShowDouble(int x)
        {
            var temp =  2 * x;
            Console.WriteLine("进入2倍方法：result = {0}",temp);
        }
    }
}