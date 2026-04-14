using System;
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
    internal class Watchlist_103022400141
    {

        public void ReadJson()
        {
            string filePath = File.ReadAllText("D:\\Modul7_P3C2S\\Modul7_P3C2S\\jurnal7_2_103022400141.json");
            WatchList wl = JsonSerializer.Deserialize<WatchList>(filePath);
            Movie mv = JsonSerializer.Deserialize<Movie>(filePath);
            Console.WriteLine(wl.watchListName);
            Console.WriteLine(wl.createdBy);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("ID : " + wl.movies[i].id);
                Console.WriteLine("Title :" + wl.movies[i].title);
                Console.WriteLine("Year :" + wl.movies[i].year);
                Console.WriteLine("Genre : " + wl.movies[i].genre);
                Console.WriteLine("Rating :"+wl.movies[i].rating);


            }
        }
        }
}

