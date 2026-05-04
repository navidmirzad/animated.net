namespace animated.DTOs.DTOs;

// A DTO is a contract between the client and server since it represents
// a shared agreement about how data will be transfered and used.

public record AnimeDTO(
    int id,
    string name,
    List<String> genre,
    int episodes,
    string studio,
    DateOnly releaseDate,
    float rating
);
