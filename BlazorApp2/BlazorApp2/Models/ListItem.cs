namespace BlazorApp2.Models
{
    public class ListItem
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Genere { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
