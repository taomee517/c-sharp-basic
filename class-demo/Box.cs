using System;

namespace class_demo
{
    public class Box
    {
        private double _length;
        private double _width;
        private double _height;

        public Box()
        {
            Console.WriteLine("Box was built!");
        }

        /*析构函数：
         *     在类的名称前加上一个波浪形（~）作为前缀，它不返回值，也不带任何参数
         *     析构函数用于在结束程序（比如关闭文件、释放内存等）之前释放资源。
         *     析构函数不能继承或重载
         */
        ~Box()
        {
            Console.WriteLine("Box was destroyed!");
        }

        public Box(double length, double width, double height)
        {
            this._length = length;
            this._width = width;
            this._height = height;
        }

        public double Length
        {
            get => _length;
            set => _length = value;
        }

        public double Width
        {
            get => _width;
            set => _width = value;
        }

        public double Height
        {
            get => _height;
            set => _height = value;
        }

        public double CalVolume()
        {
            return _length * _width * _height;
        }
    }
}