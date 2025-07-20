using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var consumer = new KafkaConsumer();
        await consumer.ConsumeMessages("chat-topic");
    }
}
