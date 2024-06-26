```
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting; //변수 선언
            Console.WriteLine("이름을 입력해 주세요 : ");
            greeting = Console.ReadLine(); // 값 할당, 초기화한다.
            
            Console.WriteLine($"당신의 이름은 {greeting} 입니다."); // 출력

        }
    }
}

```
```
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int value1, value2;

            value1= Int32.Parse(Console.ReadLine());
            value2= Int32.Parse(Console.ReadLine());
            int result = value1 + value2;
            Console.WriteLine(result);

        }
    }
}
```
```
namespace quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1 = Int32.Parse(Console.ReadLine());
            int value2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{value1} {value2}");
            int temp = value1;
            value1 = value2;
            value2 = temp;  
            Console.WriteLine($"{value1} {value2}");
        }
    }
}
```
```
string greeting = "    안녕    ";
Console.WriteLine(greeting);

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine(trimmedGreeting);

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine(trimmedGreeting);

trimmedGreeting = greeting.Trim();
Console.WriteLine(trimmedGreeting);
```
```
string greeting = "Good Morning";

Console.WriteLine(greeting.ToUpper());

Console.WriteLine(greeting.ToLower());
```
