using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Modul7_P3C2S
{
    public class Movie
    {
        [JsonInclude]
        public string id { get; set; }
        [JsonInclude]
        public string title { get; set; }
        [JsonInclude]
        public int year { get; set; }
        [JsonInclude]
        public string genre { get; set; }
        [JsonInclude]
        public double rating { get; set; }
    }
    public class WatchList
    {
        [JsonInclude]
        public string watchListName { get; set; }
        [JsonInclude]
        public string createdBy { get; set; }
        [JsonInclude]
        public List<Movie> movies { get; set; }

    }
}
        public class Watchlist_103022400030
    {
        public void ReadJSON()
        {
            string filepath = "D:\\MOD7_P3C2S\\Modul7_P3C2S\\jurnal7_2_103022400030.json";
            string jsonData = File.ReadAllText(filepath);
            Watchlist_103022400030 wl = JsonSerializer.Deserialize<Watchlist_103022400030>(jsonData);
            Console.WriteLine($"Watchlist Name: {wl.watchlist}");
            Console.WriteLine($"Created By: {wl.createdBy}");
            Console.WriteLine("Movies:");

            for (int i = 0; i < wl.movies.Count, int++;
            {
                Console.WriteLine(movie.id + movie.title + "(" + movie.year +" - "+movie.rating + ")");
            }
        }
    }
}

