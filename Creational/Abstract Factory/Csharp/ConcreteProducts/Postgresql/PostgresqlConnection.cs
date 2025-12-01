public class PostgresqlConnection : IDatabaseConnection
{
    public void Connect() => Console.WriteLine("Conectado a PostgreSQL");
    public void Disconnect() => Console.WriteLine("Desconectado de PostgreSQL");
}