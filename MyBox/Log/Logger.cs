﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyBox.Log
{
    public class Logger
    {
        private static readonly Logger Logg = new Logger();


        public Logger()
        {

        }

        public string FileName { get; set; }

        private static void WriteLogs(string dirName, string type, string content)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            if (!string.IsNullOrEmpty(path))
            {
                path = AppDomain.CurrentDomain.BaseDirectory + dirName + "//" + type + ".log";
                if (!File.Exists(path))
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                }
                if (File.Exists(path))
                {
                    StackTrace trace = new StackTrace();
                    StackFrame frame = trace.GetFrame(3);//1代表上级，2代表上上级，以此类推
                    MethodBase method = frame.GetMethod();
                    string className = method.ReflectedType.Name;
                    
                    int lineNum = frame.GetFileLineNumber();
                    StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default);
                    sw.WriteLineAsync(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + (className ?? "") + "行号："+lineNum.ToString() + " --> " + content);
                    sw.Close();
                }
            }
        }

        private static void Log(string type, string content)
        {
            WriteLogs("logs", type, content);
        }

        public static void Debug(string content)
        {
            Log("Debug", content);
        }

        public static void Info(string content)
        {
            Log("Info", content);
        }

        public static void Warn(string content)
        {
            Log("Warn", content);
        }

        public static void Error(string content)
        {
            Log("Error", content);
        }

        public static void Fatal(string content)
        {
            Log("Fatal", content);
        }
    }
}
