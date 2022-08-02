namespace VendingMachine.Domain.Common.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}