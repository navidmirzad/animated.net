using animated.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace animated.Data;

public class AnimeStoreContext : DbContext
{
    public DbSet<Anime> Anime { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<User> users { get; set; }

    public AnimeStoreContext(DbContextOptions<AnimeStoreContext> options) : base(options)
    {
        
    }
}
