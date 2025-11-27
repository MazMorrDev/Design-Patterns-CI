// Client Code - Uses the factory to create objects without knowing the concrete classes
public class Program
{
    public static void Main(string[] args)
    {
        IDatabaseConnection factory;

        // Determine which factory to use based on user input or condition
        string input = Console.ReadLine();

        // Factory selection logic - decides which concrete factory to instantiate
        if (!string.IsNullOrEmpty(input) && input.ToLower() == "postgres")
        {
            factory = new PostgresqlConnectionFactory();
        }
        else
        {
            factory = new MysqlConnectionFactory();
        }

        // Use the factory to create the appropriate database connection
        // Client code depends on abstraction (factory) not concrete implementations
        IDatabaseConnection connection = factory.CreateConnection();

        // Use the created connection object
        connection.Connect();
    }
}