using animated.DTOs.DTOs;
using animated.Repositories;

namespace animated.Models;

public class AnimeService
{
    private readonly IAnimeRepository _repository;

    public List<AnimeDTO> GetAnimes()
    {
        return _repository.GetAnime().Select(ToViewModel).ToList();
    }

    private static AnimeDTO ToViewModel(Anime anime)
    {
        return new AnimeDTO(
            anime.Id,
            anime.Name,
            anime.Genres,
            anime.Episodes,
            anime.Studio,
            anime.ReleaseDate,
            anime.Rating
            );
    }
    
}