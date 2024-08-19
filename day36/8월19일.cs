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
