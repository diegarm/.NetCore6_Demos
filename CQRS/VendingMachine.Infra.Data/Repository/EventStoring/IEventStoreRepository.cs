using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Events;

namespace VendingMachine.Infra.Data.Repository.EventStoring
{
    public interface IEventStoreRepository : IDisposable
    {
        void Store(StoredEvent theEvent);
        Task<IList<StoredEvent>> All(Guid aggregateId);
    }
}
