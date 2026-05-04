namespace animated.DTOs;

public record CreateAnimeDTO(
    string name,
    List<String> genre,
    int episodes,
    string studio,
    DateOnly releaseDate
);
