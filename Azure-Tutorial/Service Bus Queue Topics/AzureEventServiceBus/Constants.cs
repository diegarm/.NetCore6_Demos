namespace AzureEventServiceBus
{
    public enum SubscriptionNames
    {
        weekend,
        weekday
    }

    public enum SubscriptionFilterKeys
    {
        Day
    }

    public class Constants
    {
        public const string TopicName = "MessageOutbox";
        public const string ConnectionString = "Endpoint=sb://happywhats.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=iPCFMCczxUWkk1luglCWPJWI8QHOpYhHy3aofeJDOMI=";
    }
}
