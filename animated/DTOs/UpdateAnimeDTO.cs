namespace animated.DTOs;

public record UpdateAnimeDTO(
  int id,
  string name,
  List<String> genre,
  int episodes,
  string studio,
  DateOnly releaseDate,
  float rating
);