using Modul7_P3C2S;


class main
{
    public static void Main(string[] args)
    {
        FilmFavorit_103022400030 film1 = new FilmFavorit_103022400030();
        film1.ReadJSON();
        FilmFavorit_103022400075 ff = new FilmFavorit_103022400075();
        ff.ReadJson();
        WatchList_103022400075 wl = new WatchList_103022400075();
        wl.ReadJson();
        GenreDictionary_103022400075 gd = new GenreDictionary_103022400075();
        gd.ReadJson();
        Watchlist_103022400141 WL = new Watchlist_103022400141();
        WL.ReadJson();

    }


}
