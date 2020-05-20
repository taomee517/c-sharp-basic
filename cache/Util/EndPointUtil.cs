// 创建人：李鸢
// 创建时间：2020/05/20 17:34

using System;
using System.Net;
using System.Net.Sockets;

namespace cache.Util
{
    public class EndPointUtil
    {
        public static string GetLocalIp()
        {
            try
            {
                //获取本机名
                var hostName = Dns.GetHostName();
                //方法已过期，可以获取IPv4的地址
                var localhost = Dns.GetHostByName(hostName);
                //获取IPv6地址
                //IPHostEntry localhost = Dns.GetHostEntry(hostName);   
                for (var i = 0; i < localhost.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    var addr = localhost.AddressList[i];
                    if (addr.AddressFamily != AddressFamily.InterNetwork) continue;
                    var ip = localhost.AddressList[i].ToString();
                    return ip;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}