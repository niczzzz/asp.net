namespace Movies_razor.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public Movie(int id, string title, string director, int year, string description)
        {
            Id = id;
            Title = title;
            Year = year;
            Director = director;
            Description = description;
        }

        public override string ToString() => $"{Title} ({Year}),\n Director: {Director},\n Description: {Description}";
    }

    public class MovieList
    {
        public static List<Movie> All { get; set; } = new List<Movie>();
    }
}