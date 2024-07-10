```
namespace ArrayTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];//선언과 동시 초기화

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 13 * (i + 1);
                Console.WriteLine(numbers[i]);
            }
            string[] names = new string[3];
            for (int j = 0; j < numbers.Length; j++)
            {
                names[j] = Console.ReadLine();
            }
                Console.WriteLine(numbers[j]);
            }
        }
    }
```
```
