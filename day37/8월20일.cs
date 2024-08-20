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
