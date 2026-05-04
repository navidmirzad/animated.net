using animated.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapAnimeEndpoints();

app.Run();
