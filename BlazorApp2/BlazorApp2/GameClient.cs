using BlazorApp2.Models;

namespace BlazorApp2
{
    //manage data
    public static class GameClient
    {

        private static List<ListItem> games = new List<ListItem>();

        public GameClient() {
            //test data
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
    }
}
