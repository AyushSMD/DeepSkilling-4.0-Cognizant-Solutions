using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Confluent.Kafka;

namespace ConsumerApp
{
    public partial class Form1 : Form
    {
        ListBox lstMessages;

        public Form1()
        {
            InitializeComponent();

            lstMessages = new ListBox() { Top = 20, Left = 20, Width = 350, Height = 300 };
            Controls.Add(lstMessages);

            Task.Run(() => StartConsumer());
        }

        private void AddMessage(string msg)
        {
            if (lstMessages.InvokeRequired)
            {
                lstMessages.Invoke(new Action(() => lstMessages.Items.Add(msg)));
            }
            else
            {
                lstMessages.Items.Add(msg);
            }
        }

        private void StartConsumer()
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "chat-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe("chat-topic");

            while (true)
            {
                try
                {
                    var cr = consumer.Consume();
                    AddMessage($"Received: {cr.Message.Value}");
                }
                catch (Exception ex)
                {
                    AddMessage($"Error: {ex.Message}");
                }
            }
        }
    }
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Entry point to your Form
        }
    }
}
