using System.ComponentModel.DataAnnotations;

namespace animated.DTOs.DTOs;

// A DTO is a contract between the client and server since it represents
// a shared agreement about how data will be transfered and used.

public record AnimeDTO(
    [Required] int id,
    [Required] string name,
    [Required] List<string> genre,
    [Required] int episodes,
    [Required] string studio,
    [Required] DateOnly releaseDate,
    [Required][Range(0, 10)] float rating
);
