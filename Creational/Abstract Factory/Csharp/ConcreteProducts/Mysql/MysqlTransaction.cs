public class MysqlTransaction : IDatabaseTransaction
{
    public void Begin() => Console.WriteLine("Iniciando transacción MySQL");
    public void Commit() => Console.WriteLine("Confirmando transacción MySQL");
    public void Rollback() => Console.WriteLine("↩Revirtiendo transacción MySQL");
}