```
namespace OOPTest005
{

    class Person
    {
        //멤버 변수
        private string name;
        private int age;
        //property
        
        //생성자
        public Person()
        {
        }
        public Person(string _name)
        {

            name = _name;
        }
        public Person(string _name, int _age)
        {
            name = _name;
            age = _age;
            

        }
        public void Eat()
        {
            Console.WriteLine($"밥을 먹습니다.");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"{food}를 먹습니다.");
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.Eat();
            tom.Eat("오렌지");
            Console.WriteLine(tom.GetName());

            Person sam = new Person("Sam");
            Console.WriteLine(sam.GetName());
            Console.WriteLine(sam.GetAge());

            Person tony = new Person("Tony", 24);
            Console.WriteLine(tony.GetName());
            Console.WriteLine(sam.GetAge());
        }
    }
}
```
```
<property>
namespace OOPTest05
{
    class Person        //명사, 대문자로 시작!
    {
        //1.멤버 변수
        //private string name;
        //private int age;

        //Property
        public string Name{ get; set; }
        public int Age{ get; set; }

        //2.생성자 , 1개 이상
        public Person() //default 생성자
        {
        }
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //3.멤버메소드
        public void Eat()
        {
            Console.WriteLine($"밥을 먹습니다.");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"{food}를 먹습니다.");
        }

        //Getter, Setter
        //public string GetName()
        //{
        //    return Name;
        //}
        //public void SetName(string name)
        //{
        //    this.name = name;
        //}
        //public int GetAge()
        //{
        //    return age;
        //}
        //public void SetAge(int age)
        //{
        //    this.age = age;
        //}
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.Eat();
            tom.Eat("오렌지");
            //Console.WriteLine(tom.GetName());
            Console.WriteLine(tom.Name);

            Person sam = new Person("Sam");
            //Console.WriteLine(sam.GetName());
            //Console.WriteLine(sam.GetAge());
            Console.WriteLine(sam.Name);
            Console.WriteLine(sam.Age);

            Person tony = new Person("Tony", 24);
            //Console.WriteLine(tony.GetName());
            //Console.WriteLine(tony.GetAge());
            Console.WriteLine(tony.Name);
            Console.WriteLine(tony.Age);
        }
    }
}
```
```
namespace OOPTest005
{

    class Product
    {
       // private string name;
       // private int price;
        private int stock;
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("재고가 없어요");
                }
            }
        }


        public Product(string name, int price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;

        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("초코파이", 800, 10);
            product.Stock = -5;
           
        }
    }
}
```
```
