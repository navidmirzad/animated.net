using animated.Models;
using Microsoft.EntityFrameworkCore;

namespace animated.Data;

public class AnimeStoreContext(DbContextOptions<AnimeStoreContext> options) : DbContext(options)
{
    public DbSet<Anime> animes => Set<Anime>();
    public DbSet<Genre> genres => Set<Genre>();
    public DbSet<User> users => Set<User>();
}
