using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_P3C2S
{
    internal class FilmFavorit_103022400111
    {
        [JsonInclude]
        public string title {  get; set; }
        [JsonInclude]
        public string director { get; set; }
        [JsonInclude]
        public string year { get; set; }
        [JsonInclude]
        public string genre { get; set; }
        [JsonInclude]
        public int rating { get; set; }
        [JsonInclude]
        public int durationMinutes { get; set; }
        [JsonInclude]
        public bool isWatched { get; set; }

        public void ReadJson()
        {
            string filePath = "D:\\Modul7_P3C2S\\MOD7_P3C2S\\Modul7_P3C2S\\Jurnal7_1_103022400111.json";
            string jsonData = File.ReadAllText(filePath);
            FilmFavorit_103022400111 fm = JsonSerializer.Deserialize<FilmFavorit_103022400111>(jsonData);
            Console.WriteLine($"Nama film {fm.title} dan nama direktur {fm.director} dengan tahun pembuatan {fm.year} yang memiliki genre {fm.genre} \n dan ratingnya {fm.rating} \n durasi dari filmnya {fm.durationMinutes} dan {fm.isWatched}"); 
        }
    }
}
