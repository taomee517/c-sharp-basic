using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace file_demo
{
    public class BinaryReaderUtil
    {
        public static void ReadFileContent(string path)
        {
            var fileStream = new FileStream(path, FileMode.Open);
            var reader = new BinaryReader(fileStream, Encoding.UTF8);
            while (true)
            {
                try
                {
                    var ch = reader.ReadChar();
                    Console.Write(ch);
                }
                catch (Exception e)
                {
                    if (e is EndOfStreamException)
                    {
                        break;
                    }

                    throw;
                }
            }
            reader.Close();
        }
    }
}