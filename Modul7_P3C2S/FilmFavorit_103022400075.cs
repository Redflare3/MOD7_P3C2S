using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_P3C2S
{
    internal class FilmFavorit_103022400075
    {
        [JsonInclude]
        public string title { get; set; }
        [JsonInclude]
        public string director { get; set; }
        [JsonInclude]
        public int year { get; set; }
        [JsonInclude]
        public string genre { get; set; }
        [JsonInclude]
        public double rating { get; set; }
        [JsonInclude]
        public int durationMinutes { get; set; }
        [JsonInclude]
        public bool isWatched { get; set; }

        public void ReadJson()
        {
            string filePath = File.ReadAllText("D:\\MODUL7_3C2S\\MOD7_P3C2S\\Modul7_P3C2S\\jurnal7_1_103022400075.json");
            FilmFavorit_103022400075 film = JsonSerializer.Deserialize <FilmFavorit_103022400075>(filePath);
            Console.WriteLine($"Title: {film.title} \n Director: {film.director} \n Year: {film.year} \n Genre: {film.genre} \n Rating: {film.rating} \n Duration Minutes: {film.durationMinutes} \n Watched? {film.isWatched}");

        }
    }
}
