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
