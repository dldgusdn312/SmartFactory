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
```
Quiz1
//1~100까지 계속 더한 결과값은 5050입니다.
//이를 메소드로 만들어서 Main에서는 결과만 출력하고
//5050 결과는 NumberAdd 메소드를 만들어서 동작시켜 보자.

using System.Numerics;

namespace VariableChange
{
        internal class Program
        {
            static void Main(string[] args)
            {
                int result = NumberAdd();
                Console.WriteLine("1부터 100까지의 합: " + result);
            }
            static int NumberAdd()
            {
                int sum = 0;
                for (int i = 1; i <= 100; i++)
                {
                    sum += i;
                }
                return sum;
            }
        }
    }
```
```
<배열 요소값 중 가장 큰 값 max 출력하기>
using System.Numerics;

namespace VariableChange
{
        internal class Program
        {
            static void Main(string[] args)
            {
            int[] arr = { -7, 5, 60, -33, 42};
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"최대값은 : {max}");
            }
        }
    }
```
```
<메소드 이용하여 total값 구하기>
namespace Scoreapp02
{
    internal class Program
    {
        static int TotalScore(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            //국어, 영어, 수학 (90,90,91)
            int totalScore = TotalScore(90, 90, 91);
            Console.WriteLine(totalScore); //271
            Console.WriteLine($"평균값 : {totalScore / 3.0:F2}");
        }
    }
}
```
```
Quiz 2 
using static System.Formats.Asn1.AsnWriter;

namespace Scoreapp02
{
    internal class Program
    {
        //성적 입력 함수를 만들어 주세요. 3과목
        static int[] InputThreeScore()
        {
            int[] score = new int[3];
            Console.WriteLine("국어 : ");
            score[0] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("영어 : ");
            score[1] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("수학 : ");
            score[2] = Int32.Parse(Console.ReadLine());
        }
        static int TotalScore(int[] arr)
        {
            int totalscore = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                totalscore += arr[i];
            }
            return totalscore;
        }
        static double GetAvg(int totalScore)
        {
            double avg = totalScore / 3.0;
            return avg;
        }
        static void Main(string[] args)
        {
            int[] score = InputThreeScore();
            int total = TotalScore(score);
            double average = GetAvg(total);

            Console.WriteLine($"총점 : {total}");
            Console.WriteLine($"평균 : {average:F2}");
        }
    }
}
```
```
<book 만들기>
namespace OOP01
{
    class Book
    {
        string Title;
        decimal ISBN13;
        string Contents;
        string Author;
        int PageCount;
    }
    class Student
    {
        public  int ID;
        public string Name;

        public string Run()
        {
            return "학번 : " + this.ID + " " + this.Name + "달리다.";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book guliver = new Book();

            Student woo = new Student();

            woo.ID = 1;
            woo.Name = "이현우";
            Console.WriteLine(woo.ID);
            Console.WriteLine(woo.Name);
        }
    }
}
```
```
<제곱>
namespace OOP01
{
    class Mathmatics
    {
        public int f(int x)
        {
            return x * x;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathmatics m = new Mathmatics();
            int result = m.f(5);
            Console.WriteLine(result);
        }
    }
}
```
```
<생성자 호출>
namespace ConsoleApp6
{
    class Person
    {
        //멤버변수
        public string name;
        public Person()
        {
            name = "이름없음";
            Console.WriteLine("생성자 호출");
        }
        public Person(string name)
        {
            this.name = name;
            Console.WriteLine($"인자가 1개 있는 생성자 호출 : {this.name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("홍길동");
        }
    }
}
```
```
<SwapByValue>
namespace swapbyvalue
{
    internal class Program
    {
        static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;

            Console.WriteLine($"{a} {b}");
        }
        static void Main(string[] args)
        {
            int x = 3, y = 4;
            Console.WriteLine($"{x} {y}");
            Swap(x, y);
            Console.WriteLine($"{x} {y}");
        }
    }
}
```
```
<SwapByValue ref사용>
namespace swapbyvalue
{
    internal class Program
    {
        static void Swap(ref int a,ref int b)
        {
            int temp = b;
            b = a;
            a = temp;

            Console.WriteLine($"{a} {b}");
        }
        static void Main(string[] args)
        {
            int x = 3, y = 4;
            Console.WriteLine($"{x} {y}");
            Swap(ref x,ref y);
            Console.WriteLine($"{x} {y}");
        }
    }
}
```
