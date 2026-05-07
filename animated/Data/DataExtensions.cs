using Microsoft.EntityFrameworkCore;

namespace animated.Data;

public static class DataExtensions
{
    public static void migrateDB(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<AnimeStoreContext>();
        dbContext.Database.Migrate();
    }
}
