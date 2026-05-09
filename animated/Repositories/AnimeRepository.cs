using animated.Data;
using animated.Models;

namespace animated.Repositories;

public class AnimeRepository : IAnimeRepository
{
    private readonly AnimeStoreContext  _context;

    public AnimeRepository(AnimeStoreContext context)
    {
        _context = context;
    }

    public List<Anime> GetAnime()
    {
        return _context.Anime.ToList();
    }

    public List<Anime> GetAnimeByGenre(string genre)
    {
        return GetAnime().Where(anime => anime.Genres.Any(g => g.Name == genre)).ToList();
    }

    public List<Anime> GetAnimeByStudio(string studio)
    {
        return GetAnime().Where(anime => anime.Studio == studio).ToList();
    }
}