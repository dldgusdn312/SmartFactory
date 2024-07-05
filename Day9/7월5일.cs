```
<primeNumber>

using System.Security.Cryptography;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            for (int i = 0; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                        break;
                    }
                    if (cnt == 0)
                    {
                        Console.WriteLine(i);

                        cnt = 0;
                    }
                }
            }
        }
    }
}
```
```
<random / 로또>

using System.Security.Cryptography;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 7; i++) { 
            Console.WriteLine(random.Next(1,46));
            }
        }
    }
}
```
```
<평균 구하기>

using System.Security.Cryptography;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[3];
            int total = 0;
            double avg = 0.0;
            Random random = new Random();
            for (int i = 0; i < 3; i++) { 
                score[i] = random.Next(1, 101);
                total += score[i];
            }
            avg = (double)total / score.Length;
            Console.WriteLine($"평균 : {avg:F2}");
        }
    }
}
```
```
<quiz01>

using System.Security.Cryptography;

//1단계
namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Random random = new Random();
            int[] number = new int[5];
            Console.Write("로또번호 : ");
            for (int i = 0; i < 5; i++)
            {
                number[i] = random.Next(1, 46);
                Console.Write($"{number[i]} ");
            }
         
            Console.WriteLine($"보너스번호 : {random.Next(1, 46)}");
        }
    }
}
//2단계

using System.Globalization;
using System.Security.Cryptography;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];
            Random random = new Random();

            for (int i = 0; i < 7; i++)
            {
                numbers[i] = random.Next(1, 46);
                //전수조사
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        i--;
                        break;
                    }
                }
            }

            int bonusNumber = numbers[6];
            int[] lottoNumbers = new int[6];
            Array.Copy(numbers, 0, lottoNumbers, 0, 6);

            Array.Sort(lottoNumbers);
            foreach (int i in lottoNumbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"보너스 번호 {bonusNumber}");

        }
    }
}
```
```
