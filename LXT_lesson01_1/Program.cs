var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!- Lê Xuân Toàn - 2210900069");

app.Run();
