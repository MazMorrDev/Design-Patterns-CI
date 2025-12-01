public class PostgresqlTransaction : IDatabaseTransaction
{
    public void Begin() => Console.WriteLine("Iniciando transacción PostgreSQL");
    public void Commit() => Console.WriteLine("Confirmando transacción PostgreSQL");
    public void Rollback() => Console.WriteLine("Revirtiendo transacción PostgreSQL");
}