```
<서버>
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace simpleTCPServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TCPListener 클래스 이용해서 작업 - 서버만들기
            //1.Server 만들기 Binding
            //1-1. IP 만들기, Port 만들기
            IPAddress localAddr = IPAddress.Parse("192.168.0.5");
            int port = 13000;
            TcpListener server = new TcpListener(localAddr, port);
            server.Start();
            Console.WriteLine("연결을 기다리는 중 ,,,,,");
            //2. Listener,3.Accept
            using (TcpClient clinet = server.AcceptTcpClient())
            {
                Console.WriteLine("연결성공");
                //4.Write (서버 --> 클라이언트 메시지 전달)
                using (NetworkStream stream = clinet.GetStream())
                {
                    string message = "안녕하세요";
                    byte[] data = Encoding.UTF8.GetBytes(message);

                    stream.Write(data,0,data.Length);
                    Console.WriteLine($"전달한 메시지 : {message}");
                }
            }


            //5.종료
            server.Stop();
        }
    }
}
```
```
<클라이언트>
using System.Net.Sockets;
using System.Text;

namespace SimpleTCPClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "127.0.0.1";
            int port = 13000;
            //1. 서버로 접속할 클라이언트 소켓 만들기
            // 성공 시 접속됨 Connect
            TcpClient client = new TcpClient(server, port);
            //2. 메시지 받기
            NetworkStream stream = client.GetStream();

            byte[] data = new byte[256];
            int bytes = stream.Read(data, 0, data.Length);
            string responseData = Encoding.UTF8.GetString(data, 0, bytes);
            Console.WriteLine($"Received: {responseData}");

            client.Close();
        }
    }
}
```
