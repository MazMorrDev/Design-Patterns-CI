// PRODUCTO ABSTRACTO B
public interface IDatabaseCommand
{
    void Execute(string query);
    void SetConnection(IDatabaseConnection connection);
}