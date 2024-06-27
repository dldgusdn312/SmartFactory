```
<홀수의 합, 짝수의 합 각각 구하기>
namespace ConsoleApp8

{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 = sum1 + i;
                }
                else
                {
   sum2 = sum2 + i;
                }          
            }
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}


2. 
namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum1 = 0;
            int sum2 = 0;
            while(i<=100)
            {
                if (i % 2 == 0)
                {
                    sum1 = sum1 + i;
                }
                else
                {
                    sum2 = sum2 + i;
                }
                i++;
            }
            Console.WriteLine(sum2);
            Console.WriteLine(sum1);
        }
    }
}
          
}
```
```
<1~100까지 3의배수와 7의배수만 나타내기>
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3의 배수와 7의 배수 = ");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
```
```
<1~100까지 3의배수와 7의배수를 각각 두 줄로 나타내기>
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3의 배수와 7의 배수");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} ");
                } 
            }
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine($"{i} ");
                }
            }
        }

    }
}
```
