var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Map("/postuser", (appBulder) =>
{
    appBulder.Run((context) =>
    {
        var form = context.Request.Form;
        string name = form["name"];
        string age = form["age"];
        context.Response.ContentType = "text/html; charset=utf-8";
        return context.Response.WriteAsync(
            $"<div><p>Name: {name}</p><p>Age: {age}</p></div>"
            );
    });
});

app.Run( (context) =>
{
    var path = context.Request.Path;

    if (path == "/")
    {
        path = "/index";
    }

    string target = $"./html{path}.html";

    Console.WriteLine(Path.GetFullPath(target));

    if (File.Exists(target))
    {
        context.Response.ContentType = "text/html";
        return context.Response.SendFileAsync(target);
    }
    else
    {
        context.Response.StatusCode = 404;
        return context.Response.WriteAsync("404: Error URL");
    }
});

app.Run();