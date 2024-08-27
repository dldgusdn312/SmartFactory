```
<BitConverter>
namespace BitConverterTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] boolBytes = BitConverter.GetBytes(true);
            byte[] shortBytes =BitConverter.GetBytes((short)32000); //직렬화 byte 배열로 변환
            byte[] intBytes = BitConverter.GetBytes(1652300);

            bool boolResult = BitConverter.ToBoolean(boolBytes, 0); //역직렬화
            short shortResult = BitConverter.ToInt16(shortBytes, 0);
            int intResult = BitConverter.ToInt32(intBytes, 0);

            Console.WriteLine(boolResult);
            Console.WriteLine(shortResult);
            Console.WriteLine(intResult);


        }
    }
}
```
```
<MemoryStreamTest>
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStreamTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] shortBytes = BitConverter.GetBytes((short)32000);
            byte[] intBytes = BitConverter.GetBytes(1652300);

            MemoryStream ms = new MemoryStream();
            ms.Write(shortBytes, 0, shortBytes.Length);
            ms.Write(intBytes, 0, intBytes.Length);

            ms.Position = 0;

            //MemoryStream으로부터 short를 역직렬화
            byte[] outBytes = new byte[2];
            ms.Read(outBytes, 0, 2);
            int shortResult = BitConverter.ToInt16(outBytes, 0);
            Console.WriteLine(shortResult);

            //Int 역직렬화
            outBytes = new byte[4];
            ms.Read(outBytes, 0, 4);
            int intResult = BitConverter.ToInt32(outBytes, 0);
            Console.WriteLine(intResult);

        }
    }
}
```
```
<MemoryStream quiz>
    using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Temp\\abc.txt";
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            string txt = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine(txt);

            //MemoryStream 
            MemoryStream ms = new MemoryStream();
            byte[] strBytes = Encoding.UTF8.GetBytes(txt);
            ms.Write(strBytes, 0, strBytes.Length);

            ms.Position = 0; //함정
            StreamReader sr2 = new StreamReader(ms, Encoding.UTF8, true);
            string txt2 = sr2.ReadToEnd();

            Console.WriteLine(txt2);

        }
    }
}
```
```
<Thread Quiz>
namespace ThreadQuiz
{
    internal class Program
    {
        static void Print()
        {
            Thread.Sleep(3000);
            Console.WriteLine("gg");
        }
        static void Main(string[] args)
        {
            Thread T1 = new Thread(new ThreadStart(Print));
            //t1.IsBackground = true;
            T1.Start();
            //t1.Join();


            Console.WriteLine("Main 프로그램 종료");
        }
    }
}
```
```
<WorkThread>
namespace WorkThread01
{
    internal class Program
    {
        //스레드 동기화
        private static readonly object lockObject = new object();
        static void Main(string[] args)
        {
            int threadCount = 5;

            Thread[] threads = new Thread[threadCount];
            for (int i = 0; i < threadCount; i++)
            {
                int threadIndex = i;
                threads[i] = new Thread(() => DoWork(threadIndex));
                threads[i].Start();
            }
            foreach (Thread thread in threads)
                thread.Join();
            Console.WriteLine("모든 작업이 완료되었습니다.");
        }
        static void DoWork(int index)
        {
            lock (lockObject)
            {
                Console.WriteLine($"스레드 {index} 시작 : 작업을 수행 중...");
                Thread.Sleep(1000);
                Console.WriteLine($"스레드 {index} 완료 : 작업이 끝났습니다.");
            }
            //lock (lockObject)
            //{
                
            //}
        }
    }
}

```
```
<ThreadSyncError>
using System;
using System.Threading;
namespace ThreadSyncError
{
    class Program
    {
        static int sharedValue = 0;
        private static readonly object lockObject = new object();
        

        static void Main(string[] args)
        {
            Thread incrementThread = new Thread(Increment);
            Thread decrementThread = new Thread(Decrement);

            // 스레드 시작
            incrementThread.Start();
            decrementThread.Start();

            // 스레드가 종료되기를 기다림
            incrementThread.Join();
            decrementThread.Join();

            Console.WriteLine($"최종 값: {sharedValue}");
        }

        static void Increment()
        {
            lock (lockObject)
            {
                for (int i = 0; i < 100000; i++)
                {
                    sharedValue++;
                }
            }
        }

        static void Decrement()
        {
            lock (lockObject)
            {
                for (int i = 0; i < 100000; i++)
                {
                    sharedValue--;
                }
            }
        }
    }
}
```
```
<BinaryReaderWriter>
namespace BinaryReaderWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\pic1.png";
            byte[] picture;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryReader br = new BinaryReader(fs);
                picture = br.ReadBytes((int)fs.Length);
                br.Close();
            }
            string path2 = @"‪C:\Temp\pic2.png";
            using (FileStream fs = new FileStream(path2, FileMode.Create))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(picture);
                bw.Flush(); //이진파일 Flush() 신경
                bw.Close();
            }
        }
    }
}
```
```
<MultiThreadServer>
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace MultiThreadServerV1
{
    internal class Program
    {
        static int cnt = 0;
        
        static void Main(string[] args)
        {
            Thread serverThread = new Thread(serverFunc);
            serverThread.IsBackground = true;
            serverThread.Start();
            serverThread.Join();


            Console.WriteLine("서버 프로그램을 종료합니다.");
        }
        private static void serverFunc(object obj)
        {
            using (Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 13000);
                srvSocket.Bind(endPoint);
                srvSocket.Listen(50);

                Console.WriteLine("서버 시작 ...");
                while (true)
                {
                    Socket cliSocket = srvSocket.Accept();
                    cnt++;
                    Thread workThread = new Thread(new ParameterizedThreadStart (workFunc));
                    workThread.IsBackground=true;
                    workThread.Start(cliSocket);

                }
            }
        }
        private static void workFunc(object obj)
        {
            byte[] recvBytes =  new byte[2048];
            Socket cliSocket = (Socket)obj;
            int nRecv = cliSocket.Receive(recvBytes);

            string txt = Encoding.UTF8.GetString(recvBytes,0,nRecv);
            Console.WriteLine($"클라이언트 번호 ({cnt} : {txt}");
            byte[] sendBytes = Encoding.UTF8.GetBytes("Hello : " + txt);
            cliSocket.Send(sendBytes);
            cliSocket.Close();

        }
    }
}
```
```
<MultiServerTestClient>

using System.Net.Sockets;
using System.Net;
using System.Text;

namespace MultiServerTestClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread clientThread = new Thread(clientFunc);
            clientThread.Start();
            clientThread.IsBackground = true;
            clientThread.Join();

            Console.WriteLine("클라이언트가 종료 되었습니다.");
        }
        static void clientFunc(object obj)
        {
            try
            {
                //1.소켓만들기
                Socket socket = new Socket(AddressFamily.InterNetwork,
                                        SocketType.Stream,
                                        ProtocolType.Tcp);
                //2.연결
                EndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 13000);
                socket.Connect(serverEP);
                //3.Read, Write
                byte[] buffer = Encoding.UTF8.GetBytes("잘해봅시다.");
                socket.Send(buffer);

                byte[] recvBytes = new byte[1024];
                int nRecv = socket.Receive(recvBytes);

                string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
                Console.WriteLine(txt);
                //4.종료
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
