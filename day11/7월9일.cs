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
