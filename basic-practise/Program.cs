using System;

namespace console_demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             Console.WriteLine("Hello World!");
            
            var mc = new MathCalculator();
            var factorial = mc.CalFactorial(4);
            Console.WriteLine("4的阶乘结果为：{0}", factorial);
            
            var arrayShow = new ArrayShow();
            arrayShow.ArrayPrint();
            */

            var ss = new StringSample();
            /*var msg = "Hello,World!";*/
            const string msg = "武汉，加油！";
            var bytes = ss.String2Bytes(msg);
            foreach (var b in bytes)
            {
                Console.Write(b + "\t");
            }

            var originMsg = ss.Bytes2String(bytes);
            Console.WriteLine("\n" + originMsg);

            const string hex = "7E0900000E014533224352000441362C3723623431332C332C31237D7E";
            Console.WriteLine("hex with whitespace:{0}", ss.HexInsertSpace(hex));
            var hexBytes = ss.Hex2Bytes(hex);
            Console.WriteLine("hexBytes size : {0}", hexBytes.Length);

            var x = Days.Mon;
            var y = Days.Fri;
            
            Console.WriteLine("Monday is x : {0}", (int)x);
            Console.WriteLine("Friday is y : {0}", (int)y);
        }
    }
}