using System.Net.Sockets;

namespace ChatClient
{
    public partial class ChatClientForm : Form
    {
        StreamWriter streamWriter;
        StreamReader streamReader;
        public ChatClientForm()
        {
            InitializeComponent();
        }
        private async void Connect()
        {

            // To connect to server 
            TcpClient tcpClient = new TcpClient();
           
            tcpClient.Connect("127.0.0.1", 49322); // connect to server 

            // Open Stream 
           NetworkStream networkStream= tcpClient.GetStream();

            // Read and write on stream 

            // First Write On stream  => server 
            streamWriter = new StreamWriter(networkStream);
            streamWriter.AutoFlush = true;

            // Second to read from stram => server 
            streamReader = new StreamReader(networkStream);

            while (true)
            {
                string msg = await streamReader.ReadLineAsync();
                //txtRecivedMsgs.Text+= $"Server :{msg}{Environment.NewLine}";
                txtRecivedMsgs.AppendText($"Server : {msg}{Environment.NewLine}");
              //  txtRecivedMsgs.AppendText($"Client : {txtMsgs.Text}{Environment.NewLine}"); // Append the server message to the same text box

            }

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            streamWriter.WriteLine(txtMsgs.Text);
            txtMsgs.Clear();
        }
    }
}