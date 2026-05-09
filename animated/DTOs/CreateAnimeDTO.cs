using System.ComponentModel.DataAnnotations;
using animated.Models;

namespace animated.DTOs;

public record CreateAnimeDTO(
    [Required] string Name,
    [Required] List<Genre> Genre,
    [Required] int? Episodes,
    [Required] string? Studio,
    [Required] DateOnly? ReleaseDate
);
