using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ConsumerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Must exist in Form1.Designer.cs

            // Start Kafka consumer
            Task.Run(() => StartConsumer());
        }

        private void StartConsumer()
        {
            // Dummy placeholder – replace with your Kafka consumer logic
        }
    }
}
