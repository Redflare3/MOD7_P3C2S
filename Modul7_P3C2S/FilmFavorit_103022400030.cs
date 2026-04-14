using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_P3C2S
{
    public class FilmFavorit_103022400030
    {
        [JsonInclude]
        public string title { get; set; }
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

        public void ReadJSON()
        {
            string filepath = "D:\\MOD7_P3C2S\\Modul7_P3C2S\\jurnal7_1_103022400030.json";
            string jsonData = File.ReadAllText(filepath);
            FilmFavorit_103022400030 filmFavorit = JsonSerializer.Deserialize<FilmFavorit_103022400030>(jsonData);
            Console.WriteLine($"Title: {filmFavorit.title}");
            Console.WriteLine($"Director: {filmFavorit.director}");
            Console.WriteLine($"Year: {filmFavorit.year}");
            Console.WriteLine($"Genre: {filmFavorit.genre}");
            Console.WriteLine($"Rating: {filmFavorit.rating}");
            Console.WriteLine($"Duration (minutes): {filmFavorit.durationMinutes}");
            Console.WriteLine($"Is Watched: {filmFavorit.isWatched}");
        }
    }
}

