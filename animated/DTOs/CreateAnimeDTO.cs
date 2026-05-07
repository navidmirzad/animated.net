using System.ComponentModel.DataAnnotations;

namespace animated.DTOs;

public record CreateAnimeDTO(
    [Required] string Name,
    [Required] List<string> Genre,
    [Required] int? Episodes,
    [Required] string? Studio,
    [Required] DateOnly? ReleaseDate
);
