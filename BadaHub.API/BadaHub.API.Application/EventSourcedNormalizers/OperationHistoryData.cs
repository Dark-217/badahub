namespace BadaHub.API.Application.EventSourcedNormalizers
{
    public class OperationHistoryData
    {
        public string Action { get; set; }
        public string Id { get; set; }
        public string When { get; set; }
        public string Who { get; set; }
    }
}
