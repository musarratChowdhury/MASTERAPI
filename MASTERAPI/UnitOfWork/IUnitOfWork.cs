namespace MASTERAPI.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}