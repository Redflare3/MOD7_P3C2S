using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_P3C2S
{
    internal class GenreDictionary_103022400075
    {
        [JsonInclude]
        public string id { get; set; }
        [JsonInclude] public string name { get; set; }
        [JsonInclude] public string description { get; set; }

        public void ReadJson()
        {
            string filePath = File.ReadAllText("D:\\MODUL7_3C2S\\MOD7_P3C2S\\Modul7_P3C2S\\jurnal7_3_103022400075.json");
            GenreDictionary_103022400075 gd = JsonSerializer.Deserialize<GenreDictionary_103022400075>(filePath);
            Console.WriteLine(gd.id);
            Console.WriteLine(gd.name);
            Console.WriteLine(gd.description);
        }
    }
}
