// Client Code - Uses the factory to create objects without knowing the concrete classes
public class Program
{
    public static void Main(string[] args)
    {
        // Now we use IDatabaseConnectionFactory to create factories
        // Ahora usamos IDatabaseConnectionFactory para crear factories
        IDatabaseConnectionFactory factory;
        string input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input) && input.ToLower() == "postgres")
        {
            factory = new PostgresqlConnectionFactory();
        }
        else
        {
            factory = new MysqlConnectionFactory();
        }

        // The Client create the connection
        // El factory crea la conexión
        IDatabaseConnection connection = factory.CreateConnection();
        connection.Connect();
    }
}