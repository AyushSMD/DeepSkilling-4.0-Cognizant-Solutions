using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var producer = new KafkaProducer();
        Console.WriteLine("Enter messages to send (type 'exit' to quit):");
        string message;
        while ((message = Console.ReadLine()) != "exit")
        {
            await producer.SendMessage("chat-topic", message);
        }
    }
}