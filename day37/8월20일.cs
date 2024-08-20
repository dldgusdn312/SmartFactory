```
<SimpleTCPServer_using>
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace SimpleTCPServer_using
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 서버 소켓 생성
            TcpListener server = null;
            try
            {
                int port = 8888;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                // 서버 소켓 초기화
                server = new TcpListener(localAddr, port);

                // 서버 시작
                server.Start();
                Console.WriteLine("서버가 시작되었습니다. 클라이언트를 기다리는 중...");

                // 클라이언트의 연결을 기다림
                using (TcpClient client = server.AcceptTcpClient())
                {
                    Console.WriteLine("클라이언트가 연결되었습니다.");

                    // 네트워크 스트림을 통해 데이터를 주고받음
                    using (NetworkStream stream = client.GetStream())
                    {
                        // 클라이언트로부터 데이터를 읽음
                        byte[] buffer = new byte[256];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        Console.WriteLine("클라이언트로부터 받은 메시지: " + receivedMessage);

                        // 클라이언트에게 메시지 전송
                        string responseMessage = "메시지를 받았습니다.";
                        byte[] responseData = Encoding.UTF8.GetBytes(responseMessage);
                        stream.Write(responseData, 0, responseData.Length);
                        Console.WriteLine("클라이언트에게 응답을 전송했습니다.");
                    }
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("소켓 예외: " + e.ToString());
            }
            finally
            {
                // 서버 소켓을 종료
                if (server != null)
                {
                    server.Stop();
                }
            }

            Console.WriteLine("서버를 종료합니다.");
        }
    }
}
```
```
<SimpleTCPClient>
using System.Net.Sockets;
using System.Text;

namespace SimpleTCPClient_using
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 서버의 IP 주소 및 포트 번호를 설정
            string server = "127.0.0.1";
            int port = 8888; // 서버와 동일한 포트 번호로 수정

            try
            {
                // 서버에 연결
                TcpClient client = new TcpClient(server, port);
                // 네트워크 스트림을 통해 서버와 통신
                NetworkStream stream = client.GetStream();
                // 서버에 전송할 메시지를 준비
                string message = "Hello, Server!";
                byte[] data = Encoding.UTF8.GetBytes(message);
                // 서버로 메시지를 전송
                stream.Write(data, 0, data.Length);
                Console.WriteLine("서버로 메시지를 전송했습니다: " + message);
                // 서버로부터 응답을 받음
                data = new byte[256];
                int bytes = stream.Read(data, 0, data.Length);
                string responseData = Encoding.UTF8.GetString(data, 0, bytes);
                Console.WriteLine($"서버로부터 받은 메시지: {responseData}");
                // 스트림과 클라이언트 소켓 종료
                stream.Close();
                client.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine("소켓 예외: " + e.ToString());
            }
            Console.WriteLine("클라이언트를 종료합니다.");
        }
    }
}
```
```
<EchoServer>
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace MultipleEchoServer
{
    internal class Program
    {
        static int cnt = 0;
        static void Main(string[] args)
        {
            Thread serverThread = new Thread(ServerAction);
            serverThread.IsBackground = true;

            serverThread.Start(); serverThread.Join();
            Console.WriteLine("Echo Server 메인프로그램 종료!!!");
        }
        private static void ServerAction(object obj)
        {
            using (Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 13000);

                srvSocket.Bind(endPoint);
                srvSocket.Listen(50);

                Console.WriteLine("메아리 서버(Echo Server) 시작...");
                while (true)
                {
                    Socket cliSocket = srvSocket.Accept(); //여기까지 동작은 공통입니다.
                    cnt++; //클라이언트를 구분하기 위한 카운트 증가

                    //Read,Write 기능은 따로 스레드를 만들어 
                    Thread workThread = new Thread(new ParameterizedThreadStart(workAction));
                    workThread.IsBackground = true;
                    workThread.Start(cliSocket);
                }
            }
        } // end of serveraction
        private static void workAction(object obj)
        {
            byte[] recvBytes = new byte[1024];
            Socket cliSocket = (Socket)obj;
            int nRecv = cliSocket.Receive(recvBytes);

            string echotxt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
            Console.WriteLine($"클라이언트로부터 받은 번호와 메세지 ({cnt}) : {echotxt}");
            byte[] echoMessage = Encoding.UTF8.GetBytes("Echo : " + echotxt);
            cliSocket.Send(echoMessage);
            cliSocket.Close();
        } // end of workaction
    }
}
```
```
<EchoClient>
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace MultipleEchoClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread clientThread = new Thread(clientFunc);
            clientThread.Start();
            clientThread.IsBackground = true;
            clientThread.Join();

            Console.WriteLine("Echo Server가 종료 되었습니다.");
        }
        static void clientFunc(object obj)
        {
            try
            {
                // 1. 소켓 만들기
                Socket socket = new Socket(AddressFamily.InterNetwork,
                                           SocketType.Stream,
                                           ProtocolType.Tcp);

                // 2. 서버에 연결
                EndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 13000);
                socket.Connect(serverEP);

                Console.WriteLine("Echo Server에 연결되었습니다. 종료하려면 'exit'를 입력하세요.");

                while (true)
                {
                    // 3. 메시지 입력 및 전송
                    Console.Write("메세지 작성: ");
                    string userInput = Console.ReadLine(); // 사용자 입력 받기

                    // 'exit' 입력 시 프로그램 종료
                    if (userInput.ToLower() == "exit")
                    {
                        break;
                    }

                    byte[] echoBuffer = Encoding.UTF8.GetBytes(userInput);
                    socket.Send(echoBuffer);

                    // 4. 서버로부터 응답 수신
                    byte[] recvBytes = new byte[1024];
                    int nRecv = socket.Receive(recvBytes);

                    string echotxt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
                    Console.WriteLine($"{echotxt}");
                }

                // 5. 소켓 종료
                socket.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
```
```
