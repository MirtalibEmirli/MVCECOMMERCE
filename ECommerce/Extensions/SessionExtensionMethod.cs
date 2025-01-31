using Newtonsoft.Json;

namespace ECommerce.Extensions
{
    public static class SessionExtensionMethod
    {
        public static void SetObject(this ISession session,string key, object obj)
        {
            string objectString = JsonConvert.SerializeObject(obj);
            session.SetString(key,objectString);
        }
       public static T GetObject<T>(this ISession session,string key)where T : class
        {
            string valueString= session.GetString(key);
            return string.IsNullOrEmpty(valueString) ? null : JsonConvert.DeserializeObject<T>(valueString);
        }
    }
}
