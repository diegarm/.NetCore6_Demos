using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Abstract;
using VendingMachine.Domain.Common.Interfaces;
using VendingMachine.Domain.Events;
using VendingMachine.Infra.Data.Repository.EventStoring;

namespace VendingMachine.Infra.Data.EventStoring
{
    public class SqlEventStore : IEventStore
    {
        private readonly IEventStoreRepository _eventStoreRepository;

        public SqlEventStore(IEventStoreRepository eventStoreRepository)
        {
            _eventStoreRepository = eventStoreRepository;
        }

        public void Save<T>(T theEvent) where T : Event
        {
            var serializedData = JsonConvert.SerializeObject(theEvent);

            var storedEvent = new StoredEvent(
                theEvent,
                serializedData,
                "ONLY_TEST");

            _eventStoreRepository.Store(storedEvent);
        }
    }
}
