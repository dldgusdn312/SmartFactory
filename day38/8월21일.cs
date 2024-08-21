```
<TCPListenerEchoServer>
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPListenerEchoServer
{
    internal class Program
    {
        private static TcpListener server = null;
        static void Main(string[] args)
        {
           
            try
            {
                IPAddress serverIP = IPAddress.Parse("127.0.0.1");
                int port = 13000;

               server = new TcpListener(serverIP, port);
                server.Start();
                Console.WriteLine("Echo Server 시작 !");
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("클라이언트가 연결 되었습니다.");

                    Thread clientThread = new Thread(ClientAction);
                    clientThread.IsBackground = true;
                    clientThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                if (server != null)
                {
                    server.Stop();
                }
            } // end of finally

        } //end of main
        static void ClientAction(object obj)
        {
            TcpClient client = (TcpClient)obj;

            using (NetworkStream stream = client.GetStream())
            {
                //받기
                byte[] buffer = new byte[2048];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string receiceMsg = Encoding.UTF8.GetString(buffer);
                Console.WriteLine("클라이언트로 부터 받은 메시지 : " + receiceMsg);
                // 보내기
                byte[] echoMsg = Encoding.UTF8.GetBytes(receiceMsg);
                stream.Write(echoMsg,0,echoMsg.Length);
                Console.WriteLine("에코메시지 전송 완료");
            }
        }
    } // end of Program Class
}
```
```
<TCPEchoClient>
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPEchoClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serverIp = "127.0.0.1";
            int port = 13000;
            TcpClient client= new TcpClient(serverIp,port);

            using (NetworkStream stream = client.GetStream())
            {

            
                Console.Write("메시지 작성 : ");
                byte[] Msg = Encoding.UTF8.GetBytes(Console.ReadLine());
                stream.Write(Msg, 0, Msg.Length);

                //메아리 받기
                byte[] echoMsgBytes = new byte[2048];
                int bytes = stream.Read(echoMsgBytes, 0, echoMsgBytes.Length);
                string echoMsg = Encoding.UTF8.GetString(echoMsgBytes);
                Console.WriteLine($"Echo 메시지 : " + echoMsg);

            }
        }
    }
}
```
```
<WinFormsEchoServer>
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace WinFormsEchoServer02
{
    public partial class Form1 : Form
    {
        private static TcpListener server = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(StartServer);
            serverThread.IsBackground = true;
            serverThread.Start();



        } // end of Form1_Load
        private void StartServer()
        {
            
            try
            {
                IPAddress serverIP = IPAddress.Parse("127.0.0.1");
                int port = 13000;

                server = new TcpListener(serverIP, port);
                server.Start();

                //textBox1.AppendText("Echo Server 시작 !");
                AppendText("Echo Server 시작 !");
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    //textBox1.AppendText("클라이언트가 연결 되었습니다.");
                    AppendText("클라이언트가 연결 되었습니다.");
                    Thread clientThread = new Thread(new ParameterizedThreadStart(ClientAction));
                    clientThread.IsBackground = true;
                    clientThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (server != null)
                {
                    server.Stop();
                }
            } // end of finally
        } // end of startServer

        private void ClientAction(object obj)
        {
            TcpClient client = (TcpClient)obj;
            try
            {
                using (NetworkStream stream = client.GetStream())
                {
                    //받기
                    byte[] buffer = new byte[2048];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string receiceMsg = Encoding.UTF8.GetString(buffer);
                    //Console.WriteLine("클라이언트로 부터 받은 메시지 : " + receiceMsg);
                    AppendText("클라이언트로 부터 받은 메시지 : " + receiceMsg);

                    // 보내기
                    byte[] echoMsg = Encoding.UTF8.GetBytes(receiceMsg);
                    stream.Write(echoMsg, 0, echoMsg.Length);
                    //Console.WriteLine(" 에코메시지 전송 완료");
                    AppendText(" 에코메시지 전송 완료");

                } 
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                

            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            } // end of finally
        }
            private void AppendText(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendText), new object[] { text });
            }
            else
            {
                textBox1.AppendText(text + Environment.NewLine);
            }
        }
    } // end of form
}
```
```
<WinFormEchoClient>
using System.Net.Sockets;
using System.Text;

namespace WinFormEchoClient02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serverIp = "127.0.0.1";
            int port = 13000;
            TcpClient client = new TcpClient(serverIp, port);

            using (NetworkStream stream = client.GetStream())
            {

               // Console.Write("메시지 작성 : ");
                byte[] Msg = Encoding.UTF8.GetBytes(textBox1.Text);
                stream.Write(Msg, 0, Msg.Length);

                //메아리 받기
                byte[] echoMsgBytes = new byte[2048];
                int bytes = stream.Read(echoMsgBytes, 0, echoMsgBytes.Length);
                string echoMsg = Encoding.UTF8.GetString(echoMsgBytes);
                //Console.WriteLine($"Echo 메시지 : " + echoMsg);
                textBox2.AppendText($"Echo 메시지 : " + echoMsg);
                client.Close();

            }
        }
    }
}
```
