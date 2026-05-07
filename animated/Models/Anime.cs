using System;

namespace animated.Models;

public class Anime
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public Genre? Genre { get; set; }
    public int GenreId { get; set; }
    public int? Episodes { get; set; }
    public string? Studio { get; set; }
    public DateOnly? ReleaseDate { get; set; }
    public int? Rating { get; set; }

}
