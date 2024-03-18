using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace UtilitiesLib
{
    public class Serializer<T>
    {
        public virtual void Serialize(T item, string filename)
        {
            string jsonString = JsonConvert.SerializeObject(item, SetSettings());
            File.WriteAllText(filename, jsonString);
        }

        public virtual T Deserialize(string filename)
        {
            string loadedJson = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<T>(loadedJson, SetSettings());
        }

        private JsonSerializerSettings SetSettings()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Converters = { new StringEnumConverter() }
            };

            return settings;
        }
    }
}
