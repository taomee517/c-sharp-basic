
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using cache.Common;
using NewLife.Caching;

namespace cache.Cache
{
   public static class CacheService
   {
//       private const string RedisUrl = "192.168.1.152:6379";
       private const string RedisUrl = "127.0.0.1:6379";
        static CacheService()
        {
//            FullRedis.Register();
            var cache = new Redis(RedisUrl, null, 6);
            FullRedis = cache;
        }

        public static ICache Instance => FullRedis;

        public static Redis FullRedis { get; }

        public static T Get<T>(string key)
        {
            if (typeof(T).IsInterface)
            {
                var value = FullRedis.Get<string>(key);
                return value.FromJson<T>();
            }

            return FullRedis.Get<T>(key);
        }

        public static bool Set<T>(string key, T value, int expire = -1)
        {
            if (typeof(T).IsInterface)
            {
                return FullRedis.Set(key, value.ToJson(), expire);
            }

            return FullRedis.Set(key, value, expire);
        }

        public static bool Set<T>(string key, T value, TimeSpan expire)
        {
            if (typeof(T).IsInterface)
            {
                return FullRedis.Set(key, value.ToJson(), expire);
            }

            return FullRedis.Set(key, value, expire);
        }

        public static bool ContainsKey(string key)
        {
            return FullRedis.ContainsKey(key);
        }

        public static int Remove(params string[] keys)
        {
            return FullRedis.Remove(keys);
        }

        public static T Replace<T>(string key, T value)
        {

            if (typeof(T).IsInterface)
            {
                return FullRedis.Replace(key, value.ToJson()).FromJson<T>();
            }

            return FullRedis.Replace(key, value);
        }

        /// <summary>累加，原子操作</summary>
        /// <param name="key">键</param>
        /// <param name="value">变化量</param>
        /// <returns></returns>
        public static long Increment(string key, long value)
        {
            return FullRedis.Increment(key, value);
        }

        /// <summary>累加，原子操作</summary>
        /// <param name="key">键</param>
        /// <param name="value">变化量</param>
        /// <returns></returns>
        public static double Increment(string key, double value)
        {
            return FullRedis.Increment(key, value);
        }

        /// <summary>递减，原子操作</summary>
        /// <param name="key">键</param>
        /// <param name="value">变化量</param>
        /// <returns></returns>
        public static long Decrement(string key, long value)
        {
            return FullRedis.Decrement(key, value);
        }

        /// <summary>递减，原子操作</summary>
        /// <param name="key">键</param>
        /// <param name="value">变化量</param>
        /// <returns></returns>
        public static double Decrement(string key, double value)
        {
            return FullRedis.Decrement(key, value);
        }

        public static void SetAll<T>(IDictionary<string, T> values, int expire = -1)
        {
            if (typeof(T).IsInterface)
            {
                FullRedis.SetAll(values.ToDictionary(f => f.Key, f => f.Value.ToJson()));
            }

            FullRedis.SetAll(values);
        }

        public static IDictionary<string, T> GetAll<T>(IEnumerable<string> keys)
        {
            try
            {
                if (typeof(T).IsInterface)
                {
                    return FullRedis.GetAll<string>(keys).ToDictionary(f => f.Key, f => f.Value.FromJson<T>());
                }

                return FullRedis.GetAll<T>(keys);
            }
            catch (Exception e)
            {
                IDictionary<string, T> result = new ConcurrentDictionary<string, T>();
                foreach (var key in keys)
                {
                    try
                    {
                        result.Add(key, FullRedis.Get<T>(key));
                    }
                    catch (Exception)
                    {
                    }

                }
                return result;
            }

        }

//        public static string[] Search(string pattern)
//        {
//            return FullRedis.Search(pattern);
//        }
    }
}