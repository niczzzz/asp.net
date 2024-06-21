using _03_Movies.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace _03_Movies.Pages.Movies
{
	public class IndexModel : PageModel
	{
		private readonly _03_Movies.Data._03_MoviesContext _context;

		public IndexModel(_03_Movies.Data._03_MoviesContext context)
		{
			_context = context;
		}

		public IList<Movie> Movie { get; set; } = default!;

		public async Task OnGetAsync()
		{
			Movie = await _context.Movie.ToListAsync();
		}
	}
}
