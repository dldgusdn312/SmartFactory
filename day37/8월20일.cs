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
<QuizServer>
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace QuizServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread serverThread = new Thread(ServerAction);
            serverThread.IsBackground = true;

            serverThread.Start();
            serverThread.Join();
            Console.WriteLine("퀴즈 서버 메인 프로그램 종료!!!");
        }

        private static void ServerAction(object obj)
        {
            using (Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 13000);

                srvSocket.Bind(endPoint);
                srvSocket.Listen(50);

                Console.WriteLine("퀴즈 서버가 시작되었습니다...");
                while (true)
                {
                    Socket cliSocket = srvSocket.Accept();
                    Thread workThread = new Thread(new ParameterizedThreadStart(QuizAction));
                    workThread.IsBackground = true;
                    workThread.Start(cliSocket);
                }
            }
        }

        private static void QuizAction(object obj)
        {
            Socket cliSocket = (Socket)obj;
            byte[] buffer = new byte[1024];
            string[] questions = {
                "문제 1: C#의 창시자는?\n1. Anders Hejlsberg\n2. James Gosling\n3. Bjarne Stroustrup",
                "문제 2: HTTP의 기본 포트 번호는?\n1. 21\n2. 80\n3. 443",
                "문제 3: OOP에서 상속을 제공하는 키워드는?\n1. class\n2. interface\n3. extends"
            };
            int[] answers = { 1, 2, 3 };  // 정답: 1, 2, 3

            for (int i = 0; i < questions.Length; i++)
            {
                // 문제 전송
                byte[] questionBytes = Encoding.UTF8.GetBytes(questions[i] + "\n정답을 입력하세요 (1, 2, 3): ");
                cliSocket.Send(questionBytes);

                // 클라이언트로부터 답 수신
                int nRecv = cliSocket.Receive(buffer);
                string clientResponse = Encoding.UTF8.GetString(buffer, 0, nRecv).Trim();

                // 정답 체크
                if (int.TryParse(clientResponse, out int clientAnswer) && clientAnswer == answers[i])
                {
                    if (i == questions.Length - 1)
                    {
                        byte[] winMessage = Encoding.UTF8.GetBytes("정답입니다! 축하합니다! 모든 문제를 맞추셨습니다. 우승하셨습니다!\n");
                        cliSocket.Send(winMessage);
                    }
                    else
                    {
                        byte[] correctMessage = Encoding.UTF8.GetBytes("정답입니다!\n");
                        cliSocket.Send(correctMessage);
                    }
                }
                else
                {
                    byte[] failMessage = Encoding.UTF8.GetBytes("오답입니다. 다음 기회에 도전하세요.\n");
                    cliSocket.Send(failMessage);
                    break;
                }
            }

            cliSocket.Close();
        }
    }
}
```
```
<QuizClient>
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace QuizClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread clientThread = new Thread(ClientFunc);
            clientThread.Start();
            clientThread.IsBackground = true;
            clientThread.Join();

            Console.WriteLine("클라이언트 프로그램이 종료되었습니다.");
        }

        static void ClientFunc(object obj)
        {
            try
            {
                // 1. 소켓 생성
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // 2. 서버에 연결
                EndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 13000);
                socket.Connect(serverEP);

                byte[] recvBytes = new byte[1024];
                int nRecv;

                while (true)
                {
                    // 3. 서버로부터 문제 수신
                    nRecv = socket.Receive(recvBytes);
                    string question = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
                    Console.Write(question);

                    // 4. 사용자 입력 받기 및 전송
                    string userInput = Console.ReadLine();
                    byte[] sendBytes = Encoding.UTF8.GetBytes(userInput);
                    socket.Send(sendBytes);

                    // 5. 서버로부터 응답 수신
                    nRecv = socket.Receive(recvBytes);
                    string response = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
                    Console.WriteLine(response);

                    // 게임 종료 체크
                    if (response.Contains("우승하셨습니다") || response.Contains("다음 기회에 도전하세요"))
                    {
                        break;
                    }
                }

                // 6. 소켓 종료
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
