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
<stack>
namespace StackTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while (stack.Count > 0)
            {

                Console.WriteLine(stack.Pop());
            }
        }
    }
}
```
```
<hashtable>
using System.Collections;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["하나"] = "One";
            ht["둘"] = "Two";
            ht["셋"] = "Three";
            ht["넷"] = "Four";

            Console.WriteLine(ht["하나"]);
            Console.WriteLine(ht["둘"]);
            Console.WriteLine(ht["셋"]);
            Console.WriteLine(ht["넷"]);
        }
    }
}
```
```
<예외처리 1>
    using System.ComponentModel;

namespace ExceptionApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;
            try
            {
                int result = a / b;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException e) 
            {
                Console.WriteLine("0으로 나누어 예외가 발생하였습니다.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("예외가 발생하였습니다.");
            }
        }
    }
}
```
```
<예외처리 2>
    namespace ExceptionApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                int a = 5;
                int b = 0;
                int result = a / b;
                throw new IndexOutOfRangeException();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("배열의 범위를 벗어났습니다.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("부모 예외클래스에 잡혔습니다.");
            }
            finally
            {
                Console.WriteLine("finally 무조건 실행됩니다.");
            }
        }
    }
}
```
```
<filetest>
using System.Linq.Expressions;

namespace FileTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "c:\\Temp\\abc.txt";
            string content = "안녕하세요 c#";

            File.WriteAllText(path, content);
            Console.WriteLine("파일 작성 성공 !");

            string path2 = "c:\\Temp\\ccc.txt";
            try
            {
                string words = File.ReadAllText(path2);
                Console.WriteLine(words);
            }
            catch (Exception ex)
            {
                Console.WriteLine("파일의 이름이 잘못되었습니다.");
            }
        }
    }
}
```
```
