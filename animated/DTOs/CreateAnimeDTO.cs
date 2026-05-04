using System.ComponentModel.DataAnnotations;

namespace animated.DTOs;

public record CreateAnimeDTO(
    [Required] string name,
    [Required] List<string> genre,
    [Required] int episodes,
    [Required] string studio,
    [Required] DateOnly releaseDate
);
