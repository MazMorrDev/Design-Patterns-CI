// Factory for MySQL
public class MysqlConnectionFactory : IDatabaseConnectionFactory
{
    public IDatabaseConnection CreateConnection() => new MysqlConnection();
}
