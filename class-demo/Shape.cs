using System;

namespace class_demo
{
    public class Shape
    {
        
        /*抽象方法不能为private, 要有实现内容，必须被子类重写*/
        public virtual double Area()
        {
            return 0;
        }
    }


    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Width
        {
            get => width;
            set => width = value;
        }

        public override double Area()
        {
            return length * width;
        }
    }


    public class Triangle : Shape
    {
        private double height;
        private double width;

        public Triangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double Area()
        {
            return height * width * 0.5;
        }
    }

    public class Calculator
    {
        public double CallArea(Shape shape)
        {
            return shape.Area();
        }
    }


    /*
    public class Validator
    {
        static void Main(string[] args)
        {
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
    */
}