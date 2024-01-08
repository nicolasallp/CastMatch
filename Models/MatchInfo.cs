namespace castmatch.Models
{
    public class MatchInfo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Year { get; set; }
        public int Popularity { get; set; }
        public string[]? Character { get; set; }
        public string[]? ImageUrl { get; set; }
        public bool IsMovie { get; set; }
        public bool IsPerson { get; set; }
	}
}
