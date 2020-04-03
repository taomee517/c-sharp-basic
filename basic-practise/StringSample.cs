using System;
using System.Linq;
using System.Text;

namespace console_demo
{
    public class StringSample
    {
        public byte[] String2Bytes(string msg)
        {
            return System.Text.Encoding.Default.GetBytes(msg);
        }

        public string Bytes2String(byte[] bytes)
        {
            return System.Text.Encoding.Default.GetString(bytes);
        }

        /*16进制字符串转为字节数组*/
        public byte[] Hex2Bytes(string hex)
        {
            var result = new byte[hex.Length/2];
            var sb = new StringBuilder("0x");
            for (int i = 0; i < hex.Length; i++)
            {
                var c = hex[i];
                sb.Append(c);
                if (i%2==1)
                {
                    var singleHex = sb.ToString();
                    result[i / 2] = Convert.ToByte(singleHex,16);
                    sb = new StringBuilder("0x");
                }
            }
            return result;
        }


        public string HexInsertSpace(string hex)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < hex.Length; i++)
            {
                var c = hex[i];
                sb.Append(c);
                if (i%2==1)
                {
                    sb.Append(' ');
                }
            }

            return sb.ToString();
        }
    }
}