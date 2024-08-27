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
```
namespace CToF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 4;
            int c = 3;

            int d = (a + b) / c;
            int e = (a + b) % c;

            Console.WriteLine(d);
            Console.WriteLine(e);

            
        }
    }
}
```
```
double radius = 2.5;
Console.WriteLine(Math.PI);

double area = Math.PI * radius * radius;
Console.WriteLine($"{area:F2}");
```
```
namespace quiz02
{

    internal class Program

    {
        static void Main(string[] args)

        {

            Console.Write("반지름을 입력하시오 : ");

            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;

            Console.WriteLine($"반지름 넓이 : {area:F2}");

        }
     }
    }
```
```
namespace ifapp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            if (name == "홍길동")
            {
                Console.WriteLine("1. 나는 {0} 입니다", name);

            }
            else if(name == "이순신")
            {
                Console.WriteLine("2. 나는 {0} 입니다", name);
            }
            else
            {
                Console.WriteLine("3. 나는 {0} 입니다", name);
            }
        }
    }
}
```
```
namespace FirstFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("1부터 100까지 합을 구하시오.");
            for (int i = 0; i <= 100; i++)
            {
                sum = sum + i ;
                
            }
            
            Console.WriteLine(sum);
        }
    }
}
```
```
namespace whileApp
{
internal class Program
{
static void Main(string[] args)
{
int i = 1;
int sum = 0;

        while (i <= 100)
        {
            sum += i++;
        }
        Console.WriteLine(sum);
    }
}
}
```
