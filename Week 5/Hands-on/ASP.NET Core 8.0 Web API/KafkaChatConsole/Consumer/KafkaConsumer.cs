using Confluent.Kafka;
using System;
using System.Threading;
using System.Threading.Tasks;

public class KafkaConsumer
{
    private readonly IConsumer<Null, string> _consumer;

    public KafkaConsumer()
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };
        _consumer = new ConsumerBuilder<Null, string>(config).Build();
    }

    public async Task ConsumeMessages(string topic)
    {
        _consumer.Subscribe(topic);
        Console.WriteLine($"Listening to topic '{topic}'...");

        while (true)
        {
            var cr = _consumer.Consume();
            Console.WriteLine($"Received: {cr.Message.Value}");
        }
    }
}

