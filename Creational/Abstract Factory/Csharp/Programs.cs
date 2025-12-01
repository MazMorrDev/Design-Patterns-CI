public class Program
{
    public static void Main(string[] args)
    {
        // El cliente trabaja con la FÁBRICA ABSTRACTA
        // The Client works with the Abstract Factory
        IDatabaseFactory factory;
        
        Console.WriteLine("¿Qué base de datos? (postgres/mysql): ");
        string input = Console.ReadLine();

        // Selección de FAMILIA completa
        // Selection of all the family
        if (input?.ToLower() == "postgres")
        {
            factory = new PostgresqlFactory();
            Console.WriteLine("Usando FAMILIA PostgreSQL completa");
        }
        else
        {
            factory = new MysqlFactory();
            Console.WriteLine("Usando FAMILIA MySQL completa");
        }

        // Crear FAMILIA completa de productos compatibles
        // Create all the family of compatible products
        IDatabaseConnection connection = factory.CreateConnection();
        IDatabaseCommand command = factory.CreateCommand();
        IDatabaseTransaction transaction = factory.CreateTransaction();

        // Usar productos de la misma familia (garantizados compatibles)
        // Use products from the same family (compatibility garantized)
        connection.Connect();
        command.SetConnection(connection);
        transaction.Begin();
        command.Execute("SELECT * FROM users");
        transaction.Commit();
        connection.Disconnect();
    }
}