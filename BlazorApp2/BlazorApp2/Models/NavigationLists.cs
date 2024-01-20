namespace BlazorApp2.Models
{
    public static class NavigationLists
    {
        private static List<string> projects = new List<string>() { "project1","project2","project3"};
        private static List<string> games = new List<string>() { "game1", "game2", "game3" };

        public static List<string> GetGames()
        {
            if (games.Count == 0)
            {//add test data
                for (int i = 0; i < 4; i++)
                {
                    games.Add("game "+i);
                }
            }

            return games;
        }
        public static List<string> GetProjects()
        {
            if (projects.Count == 0)
            {//add test data
                for (int i = 0; i < 4; i++)
                {
                    projects.Add("project " + i);
                }
            }

            return projects;
        }
    }
}
