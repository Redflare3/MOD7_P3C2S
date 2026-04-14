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
    public class WatchList_103022400075
    {        
        public void ReadJson()
        {
            string filePath = File.ReadAllText("D:\\MODUL7_3C2S\\MOD7_P3C2S\\Modul7_P3C2S\\jurnal7_2_103022400075.json");
            WatchList wl = JsonSerializer.Deserialize<WatchList>(filePath);
            Movie mv = JsonSerializer.Deserialize<Movie>(filePath);
            Console.WriteLine(wl.watchListName);
            Console.WriteLine(wl.createdBy);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(wl.movies[i].id);
                Console.WriteLine(wl.movies[i].title);
                Console.WriteLine(wl.movies[i].year);
                Console.WriteLine(wl.movies[i].genre);
                Console.WriteLine(wl.movies[i].rating);
                

            }
            

        }
    }

}
