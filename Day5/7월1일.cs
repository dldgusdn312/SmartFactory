```
<변수교환>
namespace VariableChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{a}_{b}");
            //변수교환
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"{a} {b}");

        }
    }
}
```
```
<while문을 이용하여 77~700까지 나타내기>
namespace VariableChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 77;
            while (i <= 700)
            {
                Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine();
        }
    }
}
```
```
<4칙연산을 메소드로 만들기>
using System.Numerics;

namespace VariableChange
{
    internal class Program
    {
        static void MyPrint()
        {
            Console.WriteLine("안녕");
        }
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static int Minus(int n1, int n2)
        {
            return n1 - n2;
        }
        static double Divide(int a, int b)
        {
            return (double)a / b;
        }
        static void Main(string[] args)
        {
            //4칙 연산 (+,-,*,/) 메소드로 만들기
            //Plus(,) Minus(,) Multiple(,) Divide(,)
            MyPrint();
            int result = Plus(1, 2);
            Console.WriteLine(result);
            Console.WriteLine(Divide(1, 2));
        }//end of Main
    }//end of Program
}
```
