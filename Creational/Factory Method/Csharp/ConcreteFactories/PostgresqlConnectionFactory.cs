
// Concrete Factory Classes - Implement the factory method to create specific products
public class PostgresqlConnectionFactory : DatabaseConnectionFactory
{
    // Creates and returns a PostgreSQL connection instance
    public override IDatabaseConnection CreateConnection() =>
        new PostgresqlConnection();
}