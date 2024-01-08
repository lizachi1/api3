using Grpc.Net.Client;
using GrpcServer;

namespace GrpcClient
{
    public partial class Form1 : Form
    {
        private const string Address = "https://localhost:7114/";
        private readonly Reverser.ReverserClient _client;

        public Form1()
        {
            InitializeComponent();

            var channel = GrpcChannel.ForAddress(Address);
            _client = new Reverser.ReverserClient(channel);
        }

        private async void DoMagic(object sender, EventArgs e)
        {
            var textToReverse = new ReverserRequest {
                FirstNumber = float.Parse(firstNumberInput.Text, System.Globalization.CultureInfo.InvariantCulture),
                SecondNumber = float.Parse(secondNumberInput.Text, System.Globalization.CultureInfo.InvariantCulture)
            };

            var reply = await ReverserReply(textToReverse);

            sumResult.Text = reply.SumResult.ToString();
            multResult.Text = reply.MultResult.ToString();
        }

        private async Task<ReverserReply> ReverserReply(ReverserRequest textToReverse)
        {
            var reply = await _client.GetReversedTextAsync(textToReverse);
            return reply;
        }
    }
}
