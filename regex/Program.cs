using System;
using System.Text.RegularExpressions;

namespace regex
{
    class Program
    {
        static void Main(string[] args)
        {
            //正则表达式中的元字符
            // 1	.	匹配除换行符以外的所有字符456
            // 2	\w	匹配字母、数字、下画线
            // 3	\s	匹配空白符（空格）
            // 4	\d	匹配数字
            // 5	\b	匹配表达式的开始或结束
            // 6	^	匹配表达式的开始
            // 7	$	匹配表达式的结束
            
            //正则表达式中表示重复的字符
            // 1	*	0次或多次字符
            // 2	?	0次或1次字符
            // 3	+	1次或多次字符
            // 4	{n}	n次字符
            // 5	{n,M} 	n到M次字符
            // 6	{n, }	n次以上字符
            
            // var pattern = @"^\d{4}$";
            var pattern = @"^CL\d{5}$";
            var regex = new Regex(pattern);
            Console.WriteLine("请输入监控量测设备号：");
            var data = Console.ReadLine();
            Console.WriteLine("匹配结果：{0}", regex.IsMatch(data));
        }
    }
}