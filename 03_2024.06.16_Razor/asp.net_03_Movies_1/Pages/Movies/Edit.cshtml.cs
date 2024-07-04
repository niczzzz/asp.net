﻿using _03_Movies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace _03_Movies.Pages.Movies
{
	public class EditModel : PageModel
	{
		private readonly _03_Movies.Data._03_MoviesContext _context;

		public EditModel(_03_Movies.Data._03_MoviesContext context)
		{
			_context = context;
		}

		[BindProperty]
		public Movie Movie { get; set; } = default!;

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
			if (movie == null)
			{
				return NotFound();
			}
			Movie = movie;
			return Page();
		}

		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see https://aka.ms/RazorPagesCRUD.
		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_context.Attach(Movie).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!MovieExists(Movie.Id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return RedirectToPage("./Index");
		}

		private bool MovieExists(int id)
		{
			return _context.Movie.Any(e => e.Id == id);
		}
	}
}
