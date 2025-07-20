using Confluent.Kafka;
using System;
using System.Threading.Tasks;

public class KafkaProducer
{
    private readonly IProducer<Null, string> _producer;

    public KafkaProducer()
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };
        _producer = new ProducerBuilder<Null, string>(config).Build();
    }

    public async Task SendMessage(string topic, string message)
    {
        var result = await _producer.ProduceAsync(topic, new Message<Null, string> { Value = message });
        Console.WriteLine($"Sent: {result.Value} to {result.TopicPartitionOffset}");
    }
}
