using System;
using System.Windows.Forms;
using Confluent.Kafka;

namespace ProducerApp
{
    public partial class Form1 : Form
    {
        TextBox txtMessage;
        Button btnSend;

        public Form1()
        {
            InitializeComponent();

            txtMessage = new TextBox() { Top = 20, Left = 20, Width = 250 };
            btnSend = new Button() { Top = 60, Left = 20, Text = "Send" };

            btnSend.Click += BtnSend_Click;

            Controls.Add(txtMessage);
            Controls.Add(btnSend);
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

            using var producer = new ProducerBuilder<Null, string>(config).Build();
            var message = txtMessage.Text;

            try
            {
                var dr = await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
                MessageBox.Show($"Sent: {dr.Value}");
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
