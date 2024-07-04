using Microsoft.AspNetCore.Mvc.RazorPages;

using Movies_razor.Models;

namespace Movies_razor.Pages
{
    public class IndexModel : PageModel
    {
        public List<Movie> movies { get; set; } = MovieList.All;

        public List<PictureShow> pictureShows { get; set; } = Schedule.schedules;


        public List<PictureShow> DisplayedShows { get; private set; } = new List<PictureShow>();
        public void OnGet()
        {
            DisplayedShows = pictureShows;
        }

    }
}


