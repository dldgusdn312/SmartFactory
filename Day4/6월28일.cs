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
