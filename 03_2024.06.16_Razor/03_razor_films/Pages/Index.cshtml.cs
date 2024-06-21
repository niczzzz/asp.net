using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _03_razor_films.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; } = "";
        public void OnGet(string name)
        {
            Message = $"Name: {name}";
        }
    }
}