```
<quiz01>
namespace OOPApp
{

    class Car
    {
        public string brand;
        public int speed;
        public Car()
        {
            speed = 70;
            brand = "현대";
        }
        public void ShowSpeed()
        {
            Console.WriteLine(speed);
        }
        public void ShowBrand()
        {
            Console.WriteLine(brand);
        }
        public virtual void ShowName()
        {
            Console.WriteLine("자동차 입니다.");
        }
        public void ShowSpeed(string position, int time)
        {
            Console.WriteLine("현재" + position + "방향으로 " + speed + "km의 속도로 가고 있고 예상 도착 시간은 " + time + "시 입니다.");
        }
    }
    class Truck : Car
    {
        public Truck()
        {
            speed = 50;
        }

        public override void ShowName()
        {
            Console.WriteLine("트럭 입니다.");
        }
    }
    class Bus : Car
    {
        public Bus()
        {
            brand = "두산";
            speed = 30;
        }
        public override void ShowName()
        {
            Console.WriteLine("버스 입니다.");
        }
    }
    class Taxi : Car
    {
        public Taxi()
        {
            brand = "KIA";
            speed = 100;
        }
        public override void ShowName()
        {
            Console.WriteLine("택시 입니다.");
        }
    }

    internal class Program

    {
        static void Main(string[] args)

        {
            Car car = new Car();
            car.ShowName();
            car.ShowBrand();
            car.ShowSpeed();
            car.ShowSpeed("안동", 2);

            Truck truck = new Truck();
            truck.ShowName();
            truck.ShowBrand();
            truck.ShowSpeed(); 

            Bus bus = new Bus();
            bus.ShowName();
            bus.ShowBrand();
            bus.ShowSpeed();

            Taxi taxi = new Taxi();
            taxi.ShowName();
            taxi.ShowBrand();
            taxi.ShowSpeed();
            taxi.ShowSpeed("서울", 3);
        }
    }
}
```
```
<interface 사용>
namespace OOOP07
{
    class Horse
    {
        public void Run()
        {
            Console.WriteLine("말이 달리고 있습니다.");
        }
    }
    class Angel
    { }
    interface IWing
    {
        public void Fly();
    }
    interface IWing2
    {
        public void Fly();
    }
    class Unicon : Horse, IWing
    {
        public void Fly()
        {
            Console.WriteLine("유니콘이 날고 있습니다.");
        }
        public void PerformMagic()
        {
            Console.WriteLine("마법을 사용합니다.");
        }
            
    }
class Program
    {
        static void Main(string[] args)
        {
            Unicon jack = new Unicon();
            jack.Run();
            jack.Fly();
            jack.PerformMagic();
        }
    }
}
```
```
