using System.ComponentModel.DataAnnotations;

namespace animated.DTOs;

public record UpdateAnimeDTO(
    [Required] int id,
    [Required] string name,
    [Required] List<string> genre,
    [Required] int episodes,
    [Required] string studio,
    [Required] DateOnly releaseDate,
    [Required][Range(0, 10)] float rating
);