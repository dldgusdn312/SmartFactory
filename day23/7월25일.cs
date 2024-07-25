```
<arraylist>
using System.Collections;

namespace ListApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (int i in list)
            {
                Console.WriteLine("");
            }
            ArrayList alist = new ArrayList();
            alist.Add('A');
            alist.Add('B');
            alist.Add('C');
            alist.Insert(2, 'E');
            alist.RemoveAt(0);

            foreach (char ch in alist)
            {
                Console.WriteLine(ch);
            }
            ArrayList blist = new ArrayList();
            blist.Add(1);
            blist.Add('Z');
            Console.WriteLine((int)blist[0]);
            Console.WriteLine((int)blist[1]);
        }
    }
}
```
```
<퀴즈 문제>
using System.Collections.Specialized;

namespace ConsoleApp18
{
    internal class Program
    {
        static int[] InputScore(int[] arr) {
            int total = 0;
            for (int i = 0; i< 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                total += arr[i];
    }
            arr[3] = total;
            return arr;
        }
        static void OutputScore(int[] arr) {
            Console.WriteLine($"총점 : {arr[3]}");
            Console.WriteLine($"평균 : {arr[3]/3.0 :F2}");
        }
        static void Main(string[] args) {
            int[] score = new int[4];
            Util util = new Util();
            util.InputScore(score);
            util.OutputScore(score);
        }
    }
}
```
```
