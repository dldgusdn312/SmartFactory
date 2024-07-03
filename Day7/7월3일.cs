```
<오버로딩>
namespace methodapp01
{
    class MyClass
    {
        public void Print()
        {
            Console.WriteLine("MyClass hello");
        }
        public void Print(string s)
        {
            Console.WriteLine(s);
        }
        public void Print(string s, double speed)
        {
            Console.WriteLine($"{s} , speed : {speed}");
        }
        public void Print(double speed, string s)
        {
            Console.WriteLine($"speed : {speed}, {s}");
        }
    } // end of MyClass
    internal class Program
    {
        static void Print()
        {
            Console.WriteLine("hello");
        }
        public static void Print(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Print();
            Print("안녕하세요");

            MyClass mc = new MyClass();
            mc.Print();
            mc.Print("반갑습니다.");
            mc.Print("수고하세요", 100);
            mc.Print(100, "하이요");
        }
    }
}
```
