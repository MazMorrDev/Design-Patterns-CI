// Factory for PostgreSQL  
public class PostgresqlConnectionFactory : IDatabaseConnectionFactory
{
    public IDatabaseConnection CreateConnection() => new PostgresqlConnection();
}