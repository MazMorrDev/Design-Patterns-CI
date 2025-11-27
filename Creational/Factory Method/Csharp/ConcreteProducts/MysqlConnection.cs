// Concrete Product Implementations - Actual database connection classes that implement the interface
public class MysqlConnection : IDatabaseConnection
{
    public void Connect() =>
        Console.WriteLine("You have been made the connection to the Mysql DB");
}