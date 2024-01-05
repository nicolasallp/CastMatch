namespace castmatch.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Year { get; set; }
        public int Popularity { get; set; }
        public string[]? Character { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsMovie { get; set; }
    }
}
