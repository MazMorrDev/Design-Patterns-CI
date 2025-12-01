// FÁBRICA ABSTRACTA - Define métodos para crear FAMILIA de productos relacionados
public interface IDatabaseFactory
{
    IDatabaseConnection CreateConnection();
    IDatabaseCommand CreateCommand();
    IDatabaseTransaction CreateTransaction();
}