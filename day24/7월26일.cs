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
<퀴즈 1 교집합 구하기>
  static void Main(string[] args)

        {

            List<int> list1 = new List<int>() {1, 2, 2, 3, 4 };

            List<int> list2 = new List<int>() {2, 3, 5, 6 };

            List<int> list3 = new List<int>();

            for (int i = 0; i < list1.Count; i++)

            {

                for (int j = 0; j < list2.Count; j++)

                {

                    if (list1[i] == list2[j] && !(list3.Contains(list1[i])))

                    {

                        list3.Add(list2[j]);

                        Console.WriteLine(list2[j]);

                        break;

                    }

                }

            }

        }

    }

}

```
```
<퀴즈문제 file>
namespace FileExam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\abc.txt";
            FileInfo fi = new FileInfo(path);
            using (StreamWriter sw = fi.CreateText())
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 5 == 0)
                        sw.Write(i + " ");
                }
            }

            using (StreamReader sr = fi.OpenText())
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
```
```
