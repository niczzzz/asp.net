using Microsoft.AspNetCore.Mvc.RazorPages;

using Movies_razor.Models;

namespace Movies_razor.Pages
{
	public class MoviesModel : PageModel
	{
		public List<Movie> movies { get; set; } = MovieList.All;
	}
}
