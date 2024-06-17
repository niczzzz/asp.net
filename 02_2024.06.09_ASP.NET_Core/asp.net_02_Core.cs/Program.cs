var builder = WebApplication.CreateBuilder();

var app = builder.Build();

List<string> quotes = new List<string>();

app.Run(async (context) =>
{
    var path = context.Request.Path;
    var fullPath = $"html/{path}";
    var response = context.Response;

    response.ContentType = "text/html; charset=utf-8";
    if (File.Exists(fullPath))
    {
        await response.SendFileAsync(fullPath);
    }
    else if (path == "/")
    {
        context.Response.ContentType = "text/html";
        await response.SendFileAsync("html/index.html");
    }
    else if (path == "/postuser")
    {
        var form = context.Request.Form;
        string quote = form["quote"];
        quotes.Add(quote);
        await context.Response.WriteAsync($"<div><p>{quote}</p></div>");
    }
    else if (path == "/quote")
    {
        context.Response.ContentType = "text/html";

        int size = quotes.Count;

        if (size > 0)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, size--);
            await context.Response.WriteAsync($"<div><p>{quotes[value]}</p></div>");
        }
        else
        {
            await context.Response.WriteAsync($"<div><p>No quotes</p></div>");
        }
        //await context.Response.WriteAsync($"<div><p>{quotes[0]}</p></div>");

        /* var stringBuilder = new System.Text.StringBuilder("<table>");
         foreach (var i in quotes)
         {
             stringBuilder.Append($"<tr><td>{i}</td></tr>");
         }
         stringBuilder.Append("</table>");
         await context.Response.WriteAsync(stringBuilder.ToString());*/
    }
    /* else
     {
         response.StatusCode = 404;
         await response.WriteAsync("<h2>Not Found</h2>");
     }*/
});
app.Run();
