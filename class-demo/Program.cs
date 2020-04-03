using System;
using System.Security.Cryptography;

namespace class_demo
{
    class Program
    {
       public static void Main(string[] args)
       {
           var box = new Box
           {
               Height = 10.0,
               Width = 10.0,
               Length = 50.0
           };
            var volume = box.CalVolume();
            Console.WriteLine("volume of box is :{0}", volume);
            
            Shape rect = new Rectangle
            {
                Length = 20.0,
                Width = 4.0
            };
            Shape triangle = new Triangle(8.0,6.0);
            var calculator = new Calculator();
            var rectArea = calculator.CallArea(rect);
            var triangleArea = calculator.CallArea(triangle);
            Console.WriteLine("长方形的面积是：{0}", rectArea);
            Console.WriteLine("三角形的面积是：{0}", triangleArea);
       }
    }
}