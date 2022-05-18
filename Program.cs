using System;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Laba2_sem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tr = new triangle();
            tr.ProgramStart();
            SaveToJSON(tr);
            var tr1 = DeserializeObject();  
            tr1.ProgramStart();
        }
        static void SaveToJSON(triangle tr)
        {
            var ObjectJSON = JsonConvert.SerializeObject(tr);
            File.WriteAllText("C:/laba2/task.json", ObjectJSON);
        }

        static triangle DeserializeObject()
        {
            string filePath = @"C:/laba2/task.json";
            if (File.Exists(filePath))
            {
                var DeserializationObj = JsonConvert.DeserializeObject<triangle>(File.ReadAllText(filePath));
                return DeserializationObj;
            }
            else
            {
                return null;
            }
        }


        
        
    }
}