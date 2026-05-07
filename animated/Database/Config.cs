namespace animated.Database;

using DotNetEnv;

public static class Config
{
    static Config()
    {
        Env.Load();
    }

    private static string Server => Environment.GetEnvironmentVariable("DB_SERVER")
        ?? throw new InvalidOperationException("DB_SERVER missing");

    private static string Port => Environment.GetEnvironmentVariable("DB_PORT")
        ?? throw new InvalidOperationException("DB_PORT missing");

    private static string Database => Environment.GetEnvironmentVariable("DB_NAME")
        ?? throw new InvalidOperationException("DB_NAME missing");

    private static string User => Environment.GetEnvironmentVariable("DB_USER")
        ?? throw new InvalidOperationException("DB_USER missing");

    private static string Password => Environment.GetEnvironmentVariable("DB_PASSWORD")
        ?? throw new InvalidOperationException("DB_PASSWORD missing");

    public static string ConnectionString =>
        $"Server={Server};Port={Port};Database={Database};User={User};Password={Password};";
}