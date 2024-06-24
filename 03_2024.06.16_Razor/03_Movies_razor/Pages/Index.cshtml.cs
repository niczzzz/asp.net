using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _03_Movies_razor.Pages
{
	public class IndexModel : PageModel
	{
		public string Message { get; }
		public IndexModel()
		{
			Message = "Hello METANIT.COM";
		}
		public string PrintTime() => DateTime.Now.ToShortTimeString();
	}
}
