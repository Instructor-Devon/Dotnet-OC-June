using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
// Somewhere in your namespace, outside other classes
namespace FunWithSession.Extensions
{

    public static class SessionExtensions
    {
        public static string DisplayWithReadable(this DateTime dt)
        {
            return dt.ToString("D");
        }
        // We can call ".SetObjectAsJson" just like our other session set methods, by passing a key and a value
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            // This helper function simply serializes theobject to JSON and stores it as a string in session
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        // List<string>
        // generic type T is a stand-in indicating that we need to specify the type on retrieval
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            // Upon retrieval the object is deserialized based on the type we specified
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }   
}