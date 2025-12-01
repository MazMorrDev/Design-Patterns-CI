public class MysqlConnection : IDatabaseConnection
{
    public void Connect() => Console.WriteLine("Conectado a MySQL");
    public void Disconnect() => Console.WriteLine("Desconectado de MySQL");
}