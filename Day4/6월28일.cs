```
<배열 기본 구조>
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
