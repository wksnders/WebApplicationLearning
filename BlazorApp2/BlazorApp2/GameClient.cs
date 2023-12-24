using BlazorApp2.Models;

namespace BlazorApp2
{
    //manage data
    public static class GameClient
    {

        private static readonly List<ListItem> games = new List<ListItem>();

        public static List<ListItem> GetGames()
        {
            if(games.Count == 0)
            {//add test data
                games.Add(new ListItem
                {
                    Id = 1,
                    Name = "Street Fighter II",
                    Genere = "Fighting",
                    Price = 19.99M,
                    ReleaseDate = new DateTime(1991, 2, 1)
                });
                games.Add(new ListItem
                {
                    Id = 2,
                    Name = "Final Fantasy II",
                    Genere = "Roleplaying",
                    Price = 59.99M,
                    ReleaseDate = new DateTime(2010, 9, 30)
                });
                games.Add(new ListItem
                {
                    Id = 3,
                    Name = "Guild Wars II",
                    Genere = "MMO",
                    Price = 59.99M,
                    ReleaseDate = new DateTime(2011, 1, 1)
                });
            }
            return games;
        }

        public static void AddGame(ListItem game) 
        { 
            games.Add(game);
        }
    }
}
