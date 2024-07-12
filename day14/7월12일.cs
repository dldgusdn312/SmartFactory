```
<Quiz1>
namespace OOPdelegateApp
{
    class Station
    {
        public string Policestation()
        {
            return "경찰서에 신고하다";
        }
        public string Firestaion()
        {
            return "소방서에 신고하다";
        }
        public string Tax()
        {
            return "국세청에 신고하다";
        }
    }

    internal class Program
    {
        delegate string Report();
        static void Main(string[] args)

        {
            Station st = new Station();
            Report report = st.Policestation;
            Console.WriteLine(report());
            report = st.Firestaion;
            Console.WriteLine(report());
            report = st.Tax;
            Console.WriteLine(report());
        }
    }
}
```
```
<list 사용>
namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            int num = 10;
            for (int i = 0; i < 5; i++)
            {
                numberList.Add(i);
                num += 10;
            }

            Console.WriteLine($"배열요소의 수 : {numberList.Count}");
            Console.WriteLine($"배열의 크기 : {numberList.Capacity}");
            numberList.RemoveAt(3);
            numberList.Remove(20);
            numberList.Insert(0, 5);
            numberList.Sort();
            numberList.Reverse();
           

            foreach (int i in numberList)
            {
                Console.WriteLine(i);
            }
                
        }
    }
}
```
```
<Quiz2>
namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> num = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                num.Add(random.Next(1, 101));
            }

            num.Sort();
            num.Reverse();

            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }

            num.Insert(0, -7);
            num.Add(-100);

           Console.WriteLine();
            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }

            num.Remove(-7);

           Console.WriteLine();
            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
```
```
