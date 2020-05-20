﻿using System;
using Newtonsoft.Json;

namespace cache.Common
{
    public static class JsonExtensions
    {
        public static string Serialize<T>(this T t) where T : class
        {
            return t.ToJson();
        }

        public static T Deserialize<T>(this string value) where T : class
        {
            return value.FromJson<T>();
        }

        private static JsonSerializerSettings _jsonSettings;

        private static JsonSerializerSettings JsonSettings =>
            _jsonSettings ?? (_jsonSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                Converters = new JsonConverter[] { new JsGuidConverter() },
                DefaultValueHandling = DefaultValueHandling.Include,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ConstructorHandling = ConstructorHandling.Default
            });

        private static JsonSerializerSettings _jsonSettingsFront;

        private static JsonSerializerSettings JsonSettingsFront =>
            _jsonSettingsFront ?? (_jsonSettingsFront = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                Converters = new JsonConverter[] { new JsGuidConverter() },
                DefaultValueHandling = DefaultValueHandling.Include,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                ConstructorHandling = ConstructorHandling.Default,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });



        public static string ToJson<T>(this T obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj, JsonSettings) : string.Empty;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return string.Empty;
        }

        public static string ToJson(this object obj, Type type)
        {
            return obj != null ? JsonConvert.SerializeObject(obj, type, JsonSettings) : string.Empty;
        }

        public static string ToJsonWithFront<T>(this T obj)
        {
            return obj != null ? JsonConvert.SerializeObject(obj, JsonSettingsFront) : string.Empty;
        }

        public static T FromJson<T>(this string json)
        {
            try
            {
                json = json.Replace("Hardware.Common.DeviceType[], Hardware.Cluster.Entities",
                    "Hardware.Common.DeviceType[], Hardware.Common");
                return string.IsNullOrWhiteSpace(json) ? default(T) : JsonConvert.DeserializeObject<T>(json, JsonSettings);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
            }

            return default(T);
        }

        public static object FromJson(this string json, Type type)
        {
            return string.IsNullOrWhiteSpace(json) ? null : JsonConvert.DeserializeObject(json, type, JsonSettings);
        }
    }

    public class JsGuidConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            try
            {
                var type = value.GetType();
                if (typeof(Guid) == type)
                {
                    var item = (Guid)value;
                    writer.WriteValue($"{item:D}");
                    writer.Flush();
                }
                else if (typeof(Guid?) == type)
                {
                    var item = (Guid?)value;
                    writer.WriteValue($"{item.Value:D}");
                    writer.Flush();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {

            if (reader.TokenType == JsonToken.Null)
            {
                return Guid.Empty;
            }
            if (!(typeof(Guid) == objectType || typeof(Guid?) == objectType))
                return Guid.Empty;
            try
            {
                var boolText = reader.Value.ToString();
                if (string.IsNullOrWhiteSpace(boolText))
                {
                    return Guid.Empty;
                }
                return Guid.TryParse(boolText, out Guid result) ? result : Guid.Empty;
            }
            catch (Exception)
            {
                throw new Exception($"Error converting value {reader.Value} to type '{objectType}'");
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Guid);
        }
    }
}
