using Prism.Events;

namespace EventAggregator.Core
{
    public class MessageSentEvent : PubSubEvent<string>
    {
    }
}
