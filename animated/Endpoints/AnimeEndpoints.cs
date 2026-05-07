using animated.DTOs;
using animated.DTOs.DTOs;

namespace animated.Endpoints;

public static class AnimeEndpoints
{

    const string GetAnimeEndpointName = "GetAnime";
 
    private static readonly List<AnimeDTO> animes = [
      new (1, "One Piece", ["Action", "Adventure", "Comedy"], 1159, "Toei Animation", new DateOnly(1999, 10, 20), 0),
      new (2, "My Hero Academia Season 1", ["Action", "Superhero"], 25, "Bones", new DateOnly(2016, 4, 3), 0),
    ];

    public static void MapAnimeEndpoints(this WebApplication app)
  {
    
      var group = app.MapGroup("/api/v1/animes");

      app.MapGet("/", () => "Welcome to Anime.NET!");

      // GET /animes
      group.MapGet("/", () => animes);

      // GET /animes/1
      group.MapGet("/{id}", (int id) =>
      {
          var games = animes.Find(anime => anime.Id == id);

          return games is null ? Results.NotFound() : Results.Ok(games);
      })
          .WithName(GetAnimeEndpointName);

      // POST /animes
      group.MapPost("/", (CreateAnimeDTO newAnime) =>
      {
          AnimeDTO anime = new(
              animes.Count + 1,
              newAnime.Name,
              newAnime.Genre,
              newAnime.Episodes,
              newAnime.Studio,
              newAnime.ReleaseDate,
              0
          );

          animes.Add(anime);
          
          return Results.CreatedAtRoute(GetAnimeEndpointName, new {id = anime.Id}, anime);
      });

      // PUT /animes/1
      group.MapPut("/{id}", (int id, UpdateAnimeDTO updatedAnime) =>
      {
          var index = animes.FindIndex(anime => anime.Id == id);

          if (index == -1)
          {
              return Results.NotFound();
          }

          animes[index] = new AnimeDTO(
              id, 
              updatedAnime.Name,
              updatedAnime.Genre,
              updatedAnime.Episodes,
              updatedAnime.Studio,
              updatedAnime.ReleaseDate,
              updatedAnime.Rating
          );

          return Results.NoContent();
      });

      // DELETE /games/1
      group.MapDelete("/{id}", (int id) =>
      {
        animes.RemoveAll(anime => anime.Id == id);

          return Results.NoContent();
      });  
  }
}
