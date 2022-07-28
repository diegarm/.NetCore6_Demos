using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Events;
using VendingMachine.Infra.Data.Context;

namespace VendingMachine.Infra.Data.Repository.EventStoring
{
    public class EventStoreRepository : IEventStoreRepository
    {
        private readonly EventStoreContext _context;

        public EventStoreRepository(EventStoreContext context)
        {
            _context = context;
        }

        public async Task<IList<StoredEvent>> All(Guid aggregateId)
        {
            return await(from e in _context.StoredEvent where e.AggregateId == aggregateId select e).ToListAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Store(StoredEvent theEvent)
        {
            _context.StoredEvent.Add(theEvent);
            _context.SaveChanges();
        }
    }
}
