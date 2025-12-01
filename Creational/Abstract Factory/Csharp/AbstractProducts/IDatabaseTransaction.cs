// PRODUCTO ABSTRACTO C
public interface IDatabaseTransaction
{
    void Begin();
    void Commit();
    void Rollback();
}