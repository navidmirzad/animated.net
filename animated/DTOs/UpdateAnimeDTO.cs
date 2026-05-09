using System.ComponentModel.DataAnnotations;
using animated.Models;

namespace animated.DTOs;

public record UpdateAnimeDTO(
    [Required] int Id,
    [Required] string Name,
    [Required] List<Genre> Genre,
    [Required] int? Episodes,
    [Required] string? Studio,
    [Required] DateOnly? ReleaseDate,
    [Required][Range(0, 10)] float Rating
);