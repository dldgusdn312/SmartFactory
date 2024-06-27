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
            Console.WriteLine();
            Console.WriteLine();
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
```
<for문 100~1까지 거꾸로 출력 -짝수만 출력, while문 100~1까지 거꾸로 출력 - 홀수만 출력>
namespace ExamApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 100; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            int j = 100;
            while (j >= 1)
            {
                if (j % 2 != 0)
                {
                    Console.Write($"{j} ");
                }
                j--;
            }
        }
    }
}
```
```
<성적입력>
namespace ExamApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("성적을 입력해 주세요 : ");
            int score = Int32.Parse(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("A학점입니다.");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B학점입니다.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C학점입니다.");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D학점입니다.");
            }
            else
            {
                Console.WriteLine("F학점입니다.");
            }
        }
    }
}
```

