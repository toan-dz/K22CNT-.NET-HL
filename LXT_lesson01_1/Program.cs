var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!- L� Xu�n To�n - 2210900069");

app.Run();
