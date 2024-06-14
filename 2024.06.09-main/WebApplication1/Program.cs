var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Map("/root", (appBuild) =>
{
    appBuild.Run(context =>
    context.Response.WriteAsync("<h1>Root page</h1>")
    );
});

app.Run((context) =>
{
    var path = context.Request.Path;

    if (path == "/")
    {
        path = "/index";
    };

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