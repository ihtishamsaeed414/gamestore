var builder = WebApplication.CreateBuilder(args);
// configuration lines

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();