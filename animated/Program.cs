using animated.Data;
using animated.Endpoints;
using Microsoft.EntityFrameworkCore;
using animated.Database;

var builder = WebApplication.CreateBuilder(args);

var connectionString = Config.ConnectionString;
    
builder.Services.AddDbContext<AnimeStoreContext>(options => {
   options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)); 
});

var app = builder.Build();

app.MapAnimeEndpoints();

app.migrateDB();

app.Run();