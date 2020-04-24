using System;
using System.IO;

namespace file_demo
{
    public class StreamUtil
    {
        public static void PrintFileContent(string path)
        {
            Console.WriteLine("打印文件内容如下：");
            var reader = new StreamReader(path);
            while (reader.Peek()!=-1)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
            reader.Close();
        }
    }
}