namespace _03_Movies_razor
{
    public class Movie
    {
        //public int Id { get; set; }
        public string? Title { get; set; }
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Description { get; set; }
        public Movie(string title, int year, string director, string description)
        {
            Title = title;
            Year = year;
            Director = director;
            Description = description;
        }

        public override string ToString() => $"{Title} ({Year}),\n Director: {Director},\n Description: {Description}";
    }
}