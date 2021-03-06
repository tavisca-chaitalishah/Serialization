﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSerialization
{
    public class JsonSerialization
    {
        public static string ConvertObjectToJson(Company employee)
        {
            var path = Environment.CurrentDirectory + "/json.txt";
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(employee, Newtonsoft.Json.Formatting.Indented);
            using (TextWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(json);
                writer.Close();
            }
            return json;
        }

        public static void ConvertjsonToObject(string jsonFormatedString)
        {
            File.ReadAllText(Environment.CurrentDirectory + "/json.txt");
            var originalData = JsonConvert.DeserializeObject<Company>(jsonFormatedString);
           
        }
    }
}

