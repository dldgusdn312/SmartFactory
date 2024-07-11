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
