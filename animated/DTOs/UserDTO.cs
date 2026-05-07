using System.ComponentModel.DataAnnotations;

namespace animated.DTOs.DTOs;

// A DTO is a contract between the client and server since it represents
// a shared agreement about how data will be transfered and used.

public record UserDTO(
    [Required] Guid Id,
    [Required] string Username,
    [Required] string Email,
    [Required] string PasswordHash
);
