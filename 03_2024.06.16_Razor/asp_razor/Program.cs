var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

app.MapRazorPages();

app.Run();

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}