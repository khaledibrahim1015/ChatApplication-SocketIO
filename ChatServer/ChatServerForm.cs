using System.Net;
using System.Net.Sockets;

namespace ChatServer
{
    public partial class ChatServerForm : Form
    {
        private readonly List<TcpClient> tcpClients = new List<TcpClient>();

        
        public ChatServerForm()
        {
            InitializeComponent();
        }
        private async void Start()
        {
            // Intiate connection for server 
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            TcpListener tcpListener = new TcpListener(iPAddress,49322);

            tcpListener.Start(); // For Os To portnumber to recive 

            MessageBox.Show("Server Start");


            // Want to acccept Connection from any number of clients

            while (true)
            {
                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync(); // for one  connection with client 
                tcpClients.Add(tcpClient);
                MessageBox.Show("Initaite connection with Client Successfully !");

                // Then => Open thread for this client to handle client 
                // Why => becuase this tcpclient get from it stream that open with server and client 

                Thread clientThread = new Thread(() => HandleClient(tcpClient));
                clientThread.Start();
               


            }
        }

        private async void HandleClient(TcpClient client)
        {
            NetworkStream networkStream = client.GetStream();
            StreamReader streamReader = new StreamReader(networkStream);
            StreamWriter streamWriter = new StreamWriter(networkStream);
       

            while (true)
            {
                string msg = await streamReader.ReadLineAsync();
                // Use Invoke() to marshal the update to the txtRecivedMsgs control to the UI thread
                //txtRecivedMsgs.Invoke((MethodInvoker)(() =>
                //{
                //    txtRecivedMsgs.Text += $"{msg}{Environment.NewLine}";
                //}));

                txtRecivedMsgs.Invoke(new MethodInvoker(delegate ()
                {
                    //txtRecivedMsgs.Text += $" Client : {msg} {Environment.NewLine}";
                    txtRecivedMsgs.AppendText($"Client : {msg}{Environment.NewLine}");
              
                    
                      //  txtRecivedMsgs.AppendText($"Server : {txtMsgs.Text}{Environment.NewLine}"); // Append the server message to the same text box

                   
                }));
            
            }




        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            foreach (TcpClient tcpClient in tcpClients)
            {
                StreamWriter streamWriter = new StreamWriter(tcpClient.GetStream());
                streamWriter.WriteLine(txtMsgs.Text);
                streamWriter.Flush(); // Flush the stream to send the data immediately
            }
        
         
            txtMsgs.Clear(); // Clear the text box after sending the message to all clients
        }
    }
}