using Microsoft.EntityFrameworkCore;

namespace BucketListServer.Databases;

public static class DatabaseExtensions
{
    public static void OpenConnect(this DbContextOptionsBuilder optionsBuilder, string database,
        string host = "localhost", int port = 5433, string username = "postgres",
        string password = "password")
    {
        var connection = $"Host={host};Port={port};Database={database};" +
                         $"Username={username};Password={password}";
        optionsBuilder.UseNpgsql(connection);
    }
}