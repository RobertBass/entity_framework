using DotNetEnv;

namespace entity_framework.config;

public class DBTask_Connection
{
    public static string GetConnectionInfo()
    {
        Env.Load();
        string? pg_user = Environment.GetEnvironmentVariable("PG_USER");
        string? pg_password = Environment.GetEnvironmentVariable("PG_PASSWORD");
        string? pg_host = Environment.GetEnvironmentVariable("PG_HOST");
        string? pg_port = Environment.GetEnvironmentVariable("PG_PORT");
        string? pg_database = Environment.GetEnvironmentVariable("PG_DATABASE");
        return $"User ID={pg_user};Password={pg_password};Host={pg_host};Port={pg_port};Database={pg_database};";
    }    
}
