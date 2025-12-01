public class MysqlCommand : IDatabaseCommand
{
    public void Execute(string query) => 
        Console.WriteLine($"Ejecutando en MySQL: {query}");
    
    public void SetConnection(IDatabaseConnection connection) =>
        Console.WriteLine("Comando MySQL configurado con conexión");
}