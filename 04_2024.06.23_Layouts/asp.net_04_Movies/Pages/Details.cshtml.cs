using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Movies_razor.Models;

namespace Movies_razor.Pages
{
    public class DetailsModel : PageModel
    {
        public Movie movie { get; set; }
        public void OnGet(int id)
        {
            movie = MovieList.All[id];
        }
    }
}
