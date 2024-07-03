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
```
<오버로딩 2>
    using System.Data;

namespace methodapp02
{
    class Bank
    {
        //1.멤버 변수
        private int money;
        //2.생성자
        public Bank()
        {
            this.money = 10000;
        }
        //3.멤버 메소드
        //4.예금하다
        public void Deposit()
        {
            Console.WriteLine($"{money} 금액을 예금하다.");
        }
        public void Deposit(int money)
        {
            Console.WriteLine($"{money} 금액을 예금하다.");
        }
        //인출하다
        public void WithDraw()
        {
            Console.WriteLine($"{money} 금액을 인출하다.");
        }
        //이체하다
        public void Transfer()
        {
            Console.WriteLine($"{money} 금액을 이체하다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank kb = new Bank();
            kb.Deposit();
            kb.Deposit(1000000);
            kb.Transfer();
            kb.WithDraw();
        }
    }
}
```
```
<메소드 사용>
namespace methodapp3
{
    class Sensor
    {
        public void ReadData()
        {
            Console.WriteLine("데이터를 읽다.");
        }
        public void ReadDate(byte data)
        {
            Console.WriteLine($"{data} 데이터를 읽다.");
        }
      //설정값 조정하기
        public void Calibrate()
        {
            Console.WriteLine("설정값을 조정하다.");
        }
        //경고메시지 보내기
        public void SendAlert()
        {
            Console.WriteLine("경고 보내기");
        }
        public void SendAlert(string message)
        {
            Console.WriteLine($"{message} 경고 보내기");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sensor sensor = new Sensor();
            sensor.ReadData();
           // byte[] arr = { 0x001, 0x002, 0x003 };
            sensor.ReadData();
            sensor.Calibrate();
            sensor.SendAlert();
            sensor.SendAlert("온도초과");
        }
    }
}
```
```
namespace ConsoleApp7
{
    class Computer
    {
        public void Run() {
            Console.WriteLine("컴퓨터를 구동합니다.");
        }
    }
    class NoteBook : Computer
    {
    }
    class Car
    {
        public string brand;
        public Car()
        {
            brand = "현대";
            Console.WriteLine("부모 클래스 생성자가 호출 되었습니다.");
        }
        public void Run()
        {
            Console.WriteLine("차가 달린다");
        }
    }
    class SuperCar : Car
    {
        public SuperCar()
        {
            Console.WriteLine("자식 클래스 생성자가 호출 되었습니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Run();
            NoteBook noteBook = new NoteBook();
            noteBook.Run();
            SuperCar superCar = new SuperCar();
            superCar.Run();
        }
    }
}
```
```
<오버라이딩>
namespace ConsoleApp8
{
    class Shape
    {
        public string name;
        public Shape()
        {
            this.name = "도형";
            Console.WriteLine("부모 클래스 생성자");
        }
        public virtual void Draw()
        {
            Console.WriteLine("도형을 그리다.");
        }
    }
    class Rectangle : Shape
    {
        public Rectangle()
        {
            this.name = "사각형";
            Console.WriteLine("자식 클래스 생성자");
        }
        public override void Draw()
        {
            Console.WriteLine("사각형을 그리다.");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Rectangle rect = new Rectangle();
                Console.WriteLine(rect.name);
                rect.Draw();
            }
        }
    }
}
```
