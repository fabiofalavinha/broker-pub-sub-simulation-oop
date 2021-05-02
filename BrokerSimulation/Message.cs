using System;

namespace BrokerSimulation
{
    public class Message
    {
        public string TopicName { get; private set; }
        public string Content { get; set; }
        public DateTime Created { get; private set; }

        public Message(string topicName)
        {
            if (string.IsNullOrWhiteSpace(topicName))
            {
                throw new ArgumentNullException(nameof(topicName));
            }
            TopicName = topicName;
            Created = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{Created}] {Content}";
        }
    }
}
