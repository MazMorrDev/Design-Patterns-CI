// Concrete Factory Classes - Implement the factory method to create specific products
public class MysqlConnectionFactory : IDatabaseConnection
{
    // Creates and returns a MySQL connection instance
    public override IDatabaseConnection CreateConnection() =>
        new MysqlConnection();
}
