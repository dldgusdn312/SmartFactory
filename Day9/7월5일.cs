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
