using animated.Data;
using animated.Endpoints;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? throw new InvalidOperationException("Connection string might be missing or empty. Check configuration - can't connect to DB.");
    
builder.Services.AddDbContext<AnimeStoreContext>(options =>
{
   options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)); 
});

var app = builder.Build();

app.MapAnimeEndpoints();

app.Run();