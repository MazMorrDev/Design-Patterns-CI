// Concrete Product Implementations - Actual database connection classes that implement the interface
public class PostgresqlConnection : IDatabaseConnection
{
    public void Connect() =>
        Console.WriteLine("You have been made the connection to the Postgres DB");
}
