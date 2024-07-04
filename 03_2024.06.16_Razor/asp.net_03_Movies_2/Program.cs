using Movies_razor.Models;

MovieList.All = new List<Movie>
    {
        new Movie ("The Shawshank Redemption", "Frank Darabont", 1994, "Drama"),
        new Movie ("The Godfather", "Francis Ford Coppola", 1972, "Drama"),
        new Movie ("The Lord of the Rings: The Return of the King", "Peter Jackson", 2003, "Fantasy"),
        new Movie ("The Lord of the Rings: The Fellowship of the Ring", "Peter Jackson", 2001, "Fantasy"),
        new Movie ("The Lord of the Rings: The Two Towers", "Peter Jackson", 2002, "Fantasy"),
        new Movie ("Forrest Gump", "Robert Zemeckis", 1994, "Drama")
    };

var builder = WebApplication.CreateBuilder(args);

// добавляем в приложение сервисы Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// добавляем поддержку маршрутизации для Razor Pages
app.MapRazorPages();

app.Run();

