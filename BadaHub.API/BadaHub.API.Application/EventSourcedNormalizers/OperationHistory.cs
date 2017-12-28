using System;
using System.Collections.Generic;
using System.Linq;
using BadaHub.API.Domain.Core.Events;
using Newtonsoft.Json;

namespace BadaHub.API.Application.EventSourcedNormalizers
{
    public class OperationHistory
    {
        public static IList<OperationHistoryData> HistoryData { get; set; }

        public static IList<OperationHistoryData> ToJavaScriptCustomerHistory(IList<StoredEvent> storedEvents)
        {
            HistoryData = new List<OperationHistoryData>();
            OperationHistoryDeserializer(storedEvents);

            var sorted = HistoryData.OrderBy(c => c.When);
            var list = new List<OperationHistoryData>();
            var last = new OperationHistoryData();

            foreach (var change in sorted)
            {
                var jsSlot = new OperationHistoryData
                {
                    Id = change.Id == Guid.Empty.ToString() || change.Id == last.Id
                        ? ""
                        : change.Id,
                    Action = string.IsNullOrWhiteSpace(change.Action) ? "" : change.Action,
                    When = change.When,
                    Who = change.Who
                };

                list.Add(jsSlot);
                last = change;
            }
            return list;
        }

        private static void OperationHistoryDeserializer(IEnumerable<StoredEvent> storedEvents)
        {
            foreach (var e in storedEvents)
            {
                var slot = new OperationHistoryData();
                dynamic values;

                switch (e.MessageType)
                {
                    case "NewOperationEvent":
                        values = JsonConvert.DeserializeObject<dynamic>(e.Data);
                        slot.Action = "NewOperation";
                        slot.When = values["Timestamp"];
                        slot.Id = values["Id"];
                        slot.Who = e.User;
                        break;
                }
                HistoryData.Add(slot);
            }
        }
    }
}
