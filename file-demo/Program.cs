using System;
using System.IO;

namespace file_demo
{
    class Program
    {
        const string path = @"D:\taomee files\work\laser range finder\test\启动命令.txt";
        static void Main(string[] args)
        {
            //读取磁盘信息
            // var drivers = DriveInfo.GetDrives();
            // foreach (var drive in drivers)
            // {
            //     Console.WriteLine("盘：" + drive.Name);
            // }
            // DriveUtil.ShowDriveInfo("C");

            
            //读取文件信息
            // var extension = Path.GetExtension(path);
            // var newPath = Path.ChangeExtension(path, "doc");
            // Console.WriteLine("文件扩展名：{0}", extension);
            // Console.WriteLine("新文件：{0}", newPath);
            // Console.WriteLine("文件路径：" + Path.GetDirectoryName(path));


            //文件流操作
            StreamUtil.PrintFileContent(path);

            var newFilePath = Path.GetDirectoryName(path) + "\\test.txt";
            var writer = new StreamWriter(newFilePath);
            writer.WriteLine("Hello,World!");
            writer.Flush();
            writer.Close();
        }
    }
}