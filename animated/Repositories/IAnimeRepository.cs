using animated.Models;

namespace animated.Repositories;

public interface IAnimeRepository
{
    List<Anime> GetAnime();
    List<Anime> GetAnimeByStudio(string studio);
    List<Anime> GetAnimeByGenre(string genre);
}