using VendingMachine.Domain.Abstract;

namespace VendingMachine.Domain.Common.Interfaces
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
