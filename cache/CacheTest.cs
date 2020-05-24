using System;
using cache.Cache;
using cache.Common;
using cache.Util;
using NewLife.Caching;
using CacheService = cache.Cache.CacheService;

namespace cache
{
    public class CacheTest
    {
        private static ICache cache = MemoryCache.Default;

        public static void Main(string[] args)
        {
//            cache.Add("key", 1);
//            cache.Add("key", 2);
//            cache["key"] = 3;

//            cache.Set("key", 4, TimeSpan.FromMinutes(1));
//            cache.Set("key", 5, TimeSpan.FromMinutes(1));
//            Console.WriteLine(cache.Get<int>("key"));
            var sn = "CL201912170001";
            var server = new ServerModel();
            server.ip = EndPointUtil.GetLocalIp();
            server.online = true;
            server.lastMsgTime = DateTime.Now.Ticks;
            CacheService.Set("Acceptor:Laser:" + sn, server,-1);
        }
    }
}