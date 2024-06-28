```
<배열 기본 구조 1>
namespace Array01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5]; //arr -> 배열의 이름
            //배열의 사용법
            /* arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5; */

            for (int i = 0; i < 5; i++)
            {
                arr[i] = i + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
```

```
<배열 기본 구조 2>
    namespace Array01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            Console.WriteLine(ch);
            char[] arr = new char[3];
            arr[0] = 'a';
            arr[1] = 'b';
            arr[2] = 'c';

            Console.WriteLine($"{arr[0]}{arr[1]}{arr[2]}");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(arr[i]);

            }
        }
    }
}
```

```
<배열 기본 구조3>
using System.Net.Http.Headers;

namespace Array01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //크기가 5인 정수형 배열 arrint를 선언하고
            //값은 10,20,30,40,50 을 입력
            int[] arrint = new int[5];
            for(int i=0; i<arrint.Length; i++)
            {
                arrint[i] = (i+1)*10;
            }
            for (int i = 0; i < arrint.Length; i++)
            {
                Console.WriteLine(arrint[i]);
            }
        }
    }
}
```

```
<배열 a~z 나열>
using System.Net.Http.Headers;

namespace Array01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[26];
            char ch = 'a';

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ch++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
```

```
<배열을 이용하여 성적을 입력받아 평균과 총점 구하기>
namespace Array01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] score = new int[3];
            Console.Write("국어 성적 : ");
            score[0] = Int32.Parse(Console.ReadLine());
            Console.Write("영어 성적 : ");
            score[1] = Int32.Parse(Console.ReadLine());
            Console.Write("수학 성적 : ");
            score[2] = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
           

            int total = score[0] + score[1] + score[2];

            // 평균 계산
            double average = total / 3.0;

            // 결과 출력
            Console.WriteLine("총점: " + total);
            Console.WriteLine("평균: " + average);
        }
    }
}
```

```
<배열 index>
namespace Arayy03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //값
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
                //index
                for (int i = 0; i < numbers.Length; i += 2)
                {
                    Console.WriteLine(numbers[i]);

                }
            }
        }
    }
}
```

```
<입력받은 문자열 거꾸로 출력하기>
using System.Threading;

namespace Arayy03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("문자열을 입력하세요 : ");
                string str = Console.ReadLine();
                string outText = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    outText += str[i];
                }
                Console.WriteLine("$역순 문자열: {outText}");
            }
        }
    }
}
```

```
<foreach 함수 사용>
namespace Arayy03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string[] fruits = { "사과", "복숭아" };

                for (int i = 0;i < fruits.Length; i++)
                {
                    Console.WriteLine(fruits[i]);
                }
                foreach (string fruit in fruits)
            {
            Console.WriteLine(fruit); }
        }
    }
}
```

```
<3의배수, 7의배수 나타내기>
namespace Arayy03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[100];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i + 1;
            }
            Console.Write("3의 배수 : ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 3 == 0)
                {
                    Console.Write($"{ num[i]} ");
                }
            }
            Console.WriteLine();
            Console.Write("7의 배수 : ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 7 == 0)
                {
                    Console.Write($"{num[i]} ");
                }
            }
        }
    }
}
```

```
<다차원 배열>
namespace Arayy03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int[,] arr = new int[N, N];
            int cnt = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i, j] = cnt++;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
```

```
<static 활용>
namespace Quiz05
{
    internal class Program
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static int Minus(int a, int b)
        {
            return a - b;
        }

        static void Main()
        {
            int v1 = 100;
            int v2 = 200;
            int plus = Plus(v1, v2);
            int minus = Minus(v1, v2);
            Console.WriteLine($"{plus} {minus}");
        }
    }
}
```

```
<Calculator 사용>
namespace calcualtorApp
{
    class Calculator
    {
        public int Multiple(int a, int b)
        {
            return a * b;
        }
        public double Divide(int a, int b)
        {
            return (double)a / b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine(cal.Multiple(5, 6));
            Console.WriteLine(cal.Divide(100,5));
        }
    }
}
```
