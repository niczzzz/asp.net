using Movies_razor.Models;
using System.Text;

MovieList.All = new List<Movie>
    {
        new Movie (0, "The Shawshank Redemption", "Frank Darabont", 1994, "Drama"),
        new Movie (1, "The Godfather", "Francis Ford Coppola", 1972, "Drama"),
        new Movie (2, "The Lord of the Rings: The Return of the King", "Peter Jackson", 2003, "Fantasy"),
        new Movie (3, "The Lord of the Rings: The Fellowship of the Ring", "Peter Jackson", 2001, "Fantasy"),
        new Movie (4, "The Lord of the Rings: The Two Towers", "Peter Jackson", 2002, "Fantasy"),
        new Movie (5, "Forrest Gump", "Robert Zemeckis", 1994, "Drama")
    };

Schedule.schedules = new List<PictureShow>
    {
        new PictureShow ("01.07.2024", 100, TimeSpan.FromHours(9), 0),
		new PictureShow ("01.07.2024", 200, TimeSpan.FromHours(11), 1),
		new PictureShow ("02.07.2024", 300, TimeSpan.FromHours(13), 2),
		new PictureShow ("03.07.2024", 400, TimeSpan.FromHours(15), 3),
		new PictureShow ("03.07.2024", 600, TimeSpan.FromHours(17), 5),
		new PictureShow ("04.07.2024", 500, TimeSpan.FromHours(19), 4)
	};


var builder = WebApplication.CreateBuilder(args);

// добавляем в приложение сервисы Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// добавляем поддержку маршрутизации для Razor Pages
app.MapRazorPages();

app.Run();

