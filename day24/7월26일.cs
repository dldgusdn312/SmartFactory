```
<list>
namespace ListExam01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr =new List<int>();
            for(int i =0; i<100; i++)
            {
                arr.Add(i+1);
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
```
```
