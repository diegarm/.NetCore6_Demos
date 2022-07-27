using VendingMachine.Domain.Abstract;

namespace VendingMachine.Domain.Common
{
    public interface IEventStore
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
