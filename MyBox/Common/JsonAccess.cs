using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace MyBox.Common
{
    public class JsonAccess
    {
        /// <summary>
        /// Write Json data
        /// </summary>
        /// <param name="path">Json file path</param>   
        /// <param name="obj">Json Data Model</param>
        public static void WriteJson(string path, object obj)
        {
            string js1 = JsonConvert.SerializeObject(obj, Formatting.Indented);
            Console.WriteLine(js1);

            var debc1 = JsonConvert.DeserializeObject<object>(js1);
            Console.WriteLine(debc1);

            using (StreamWriter sw = new StreamWriter(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Converters.Add(new JavaScriptDateTimeConverter());
                serializer.NullValueHandling = NullValueHandling.Ignore;

                JsonWriter writer = new JsonTextWriter(sw)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(writer, debc1);
                writer.Close();
                sw.Close();
            }
        }

        /// <summary>
        /// Read Json data
        /// </summary>
        /// <param name="path">Json file path</param>
        /// <returns></returns>
        public static JObject ReadJson(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                JsonTextReader reader = new JsonTextReader(sr);

                JObject jObj = (JObject)JToken.ReadFrom(reader);

                return jObj;
            }
        }
    }
}
