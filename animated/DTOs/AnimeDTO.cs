using System.ComponentModel.DataAnnotations;

namespace animated.DTOs.DTOs;

// A DTO is a contract between the client and server since it represents
// a shared agreement about how data will be transfered and used.

public record AnimeDTO(
    [Required] int Id,
    [Required] string Name,
    [Required] List<string> Genre,
    [Required] int? Episodes,
    [Required] string? Studio,
    [Required] DateOnly? ReleaseDate,
    [Required][Range(0, 10)] float Rating
);
