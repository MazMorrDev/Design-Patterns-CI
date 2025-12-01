public class PostgresqlCommand : IDatabaseCommand
{
    public void Execute(string query) => 
        Console.WriteLine($"🚀 Ejecutando en PostgreSQL: {query}");
    
    public void SetConnection(IDatabaseConnection connection) =>
        Console.WriteLine("🔗 Comando PostgreSQL configurado con conexión");
}