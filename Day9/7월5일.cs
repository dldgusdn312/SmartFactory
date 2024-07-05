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
