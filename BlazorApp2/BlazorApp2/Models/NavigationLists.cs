namespace BlazorApp2.Models
{
    public static class NavigationLists
    {
        private static Dictionary<string, string> projects = new Dictionary<string, string>();
        private static Dictionary<string, string> games = new Dictionary<string, string>();

        public static Dictionary<string, string> GetGames()
        {
            if (games.Count == 0)
            {//add test data
                for (int i = 0; i < 4; i++)
                {
                    games.Add("game "+i,"");
                }
            }

            return games;
        }
        public static Dictionary<string, string> GetProjects()
        {
            if (projects.Count == 0)
            {//add test data
                for (int i = 0; i < 4; i++)
                {
                    projects.Add("project " + i, "");
                }
            }

            return projects;
        }
    }
}
