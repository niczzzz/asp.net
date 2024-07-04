using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WebApplication1.Models;

namespace WebApplication1.Pages
{
	public class IndexModel : PageModel
	{
		[BindProperty]

		public MyUser Person { get; set; } = new("", 0);
		public string Message { get; private set; } = "���������� ������������";

		public void OnPost()
		{

			MyGroup.All.Add(Person);
			Message = $"�������� ����� �����: {Person.Name} ({Person.Age}). �����: {MyGroup.All.Count}";



		}
	}

	//public record class Product(string Name, int Price, string Company);
}