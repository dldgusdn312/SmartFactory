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
```
<quiz01>
namespace ConsoleApp14

{
    class Student
    {
        public void EnrollCoures()
        {
            Console.WriteLine(" 수강신청");
        }
        public void DropCourse()
        {
            Console.WriteLine("과목 수강신청 취소");
        }
        public void ViewGreade()
        {
            Console.WriteLine("과목 성적 확인");
        }
    }
    class Instructor

    {
        public void AssignGrade()

        {
            Console.Write("성적을 입력하세요 :");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine($"입력한 성적은 {score}점 입니다.");
        }
        public void CreatCourse()
        {
            Console.Write("등록 과정을 입력하세요 :");
            string obj = Console.ReadLine();
            Console.WriteLine($"등록된 과정은 {obj}");
        }
        public void UpdateCourse(string s)
        {
            Console.WriteLine($"{s} 수정 완료하였습니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
    
            Student stu = new Student();
           Instructor ins = new Instructor();
            stu.EnrollCoures();
            stu.DropCourse();
            stu.ViewGreade();
            ins.AssignGrade();
            ins.CreatCourse();
            ins.UpdateCourse("영어");
        }
    }
}
```
```
<abstract>
namespace ConsoleApp10
{
    internal class Program
    {
        abstract class Car
        {
            public abstract void Run();
        }
        class Bus : Car
        {
            public override void Run()
            {
                Console.WriteLine("버스가 달린다.");
            }
        }
        class Taxi : Car
        {
            public override void Run()
            {
                Console.WriteLine("택시가 달린다.");
            }
        }
        class Truck : Car
        {
            public override void Run()
            {
                Console.WriteLine("트럭이 달린다.");
            }
        }
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            Taxi taxi = new Taxi();
            Truck truck = new Truck();
            bus.Run();
            taxi.Run();
            truck.Run();

            Car car1 = new Bus();
            Car car2 = new Taxi();
            Car car3 = new Truck();
            car1.Run();
            car2.Run();
            car3.Run();
           
            //Car[] cars = new Car[3];
            //cars[0] = new Bus();
            //cars[1] = new Taxi();
            //cars[2] = new Truck();

            //Car car4 = new Bus();
            //car4.Run();
            //car4 = new Taxi();
            //car4.Run();
            //car4 = new Truck();
            //car4.Run();

        }
    }
}
```
```
<quiz02>
namespace ConsoleApp10
{
    abstract class Mammal
    {
        public abstract void Eat();
    }
    class Lion : Mammal
    {
        public override void Eat()
        {
            Console.WriteLine("사자가 먹습니다.");
        }
    }
    class Tiger : Mammal
    {
        public override void Eat()
        {
            Console.WriteLine("호랑이가 먹습니다.");
        }
    }
    class Dog : Mammal
    {
        public override void Eat()
        {
            Console.WriteLine("개가 먹습니다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal lion = new Lion();
            Mammal tiger = new Tiger();
            Mammal dog = new Dog();

            lion.Eat();
            tiger.Eat();
            dog.Eat();
        }
    }
}
```
```
namespace OOP06
{
    class Shape
    {
        //멤버변수
        private string color;
        public string Color { get; set; }       //Property
        public void SetColor(string color)
        {
            this.color = color;
        }
        public string GetColor()
        {
            return this.color;
        }

        public virtual void Draw()
        {
            Console.WriteLine("도형을 그리다.");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원을 그리다.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.SetColor("파란색");
            Console.WriteLine(circle.GetColor());
            circle.Color = "노란색";
            Console.WriteLine(circle.Color);

        }
    }
}
```
```
<property 사용>
namespace PropertyApp2
{
    class Person
    {
        private string name;
        private int age;
        public string Color { get; set; }

        public string Name
        {
            get { 
               return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;

            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("나이는 0살보다 어릴 수 없습니다.");
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Person paul = new Person();
                paul.name = "파울이";
                paul.Age = 23;

                Console.WriteLine($"이름 : {paul.name} , 나이 : {paul.age}");

            }
        }
    }
}
```
```
