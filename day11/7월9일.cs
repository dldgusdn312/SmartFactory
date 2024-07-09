```
<CallByValue 함수호출>
namespace callbyvalue01
{
    internal class Program
    {
        static int CallByValueDemo(int x) {
            return x;
        }

        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요. : ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("입력하신 정수의 값은 {0}입니다.", CallByValueDemo(inputNumber));
        }
    }
}
```
```
namespace MethodTest02
{
    internal class Program
    {
        //static void GetNumbers(out int x, out int y){
            
        //    x = 0;
        //    y = 0;
        //    }
        static void GetValue(out int x)
        {
            x = 1;
        }
        static void Main(string[] args)
        {
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());
            //    GetNumbers(out a, out b);

            //Console.WriteLine($"a에 저장된 값은 {a}입니다.");
            //Console.WriteLine($"a에 저장된 값은 {b}입니다.");
            int a = 100;
            GetValue(out a);
            Console.WriteLine($"a에 저장된 값은 {a}");

        }
   }
}
```
```
<재귀함수>
namespace Recursive01
{
    internal class Program
    {
        static void Recursive(int n)
        {
            Console.WriteLine(n++);
            Recursive(n);
        }
        static void Main(string[] args)
        {
            Recursive(0);

        }
    }
}
```
```
<팩토리얼 함수>
namespace Facotrial01
{
    internal class Program
    {
        static int Factorial(int n)
        {
            if (n <= 1)
                return n;
            else
                return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(Factorial(a));

        }
    }
}
```
```
<팩토리얼 함수 교수님 정답>
namespace Facotrial01
{
    internal class Program
    {
        static Dictionary<int, long> arr = new Dictionary<int, long>();
                
        static long Factorial(int n)
        {
            if (arr.ContainsKey(n))
            {
                return arr[n];
            }
            arr[n] = n * Factorial(n - 1);
            return arr[n];
        }
        static void Main(string[] args)
        {
            int n = 7;
            arr[0] = 1;
            arr[1] = 1;
            Console.WriteLine(Factorial(n));
        }
    }
}
```
```
