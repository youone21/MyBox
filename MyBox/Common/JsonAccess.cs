using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBox.Log;
using MyBox.Models;
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
            Logger.Debug("开始写入Json文件 " + "文件名:" + path);
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
            Logger.Debug("结束写入Json文件");
        }

        /// <summary>
        /// Read Json data
        /// </summary>
        /// <param name="path">Json file path</param>
        /// <returns></returns>
        public static object ReadJson(string path)
        {
            Logger.Debug("开始读取Json文件 " + "文件名:" + path);
            object obj = null;

            string jsonStr = File.ReadAllText(path);
            if (!string.IsNullOrEmpty(jsonStr))
            {
                try
                {
                    obj = JsonConvert.DeserializeObject<object>(jsonStr);
                }
                catch (Exception e)
                {
                    Logger.Error(e.ToString());
                }
            }
            else
            {
                Logger.Debug("Json文件:null");
            }
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    JsonTextReader reader = new JsonTextReader(sr);
            //    if (reader.LineNumber != 0)
            //    {
            //        jObj = (JObject)JToken.ReadFrom(reader);
            //    }
            //}
            Logger.Debug("结束读取Json文件");
            return obj;
        }

        public static void ReadJson(string path, object obj)
        {
            Logger.Debug("开始读取Json文件 " + "文件名:" + path);

            string jsonStr = File.ReadAllText(path);
            if (!string.IsNullOrEmpty(jsonStr))
            {
                try
                {
                    obj = JsonConvert.DeserializeObject<object>(jsonStr);
                }
                catch (Exception e)
                {
                    Logger.Error(e.ToString());
                }
            }
            else
            {
                Logger.Debug("Json文件:null");
            }
            Logger.Debug("Json文件:" + obj.ToString());
            Logger.Debug("结束读取Json文件");
        }
    }
}
