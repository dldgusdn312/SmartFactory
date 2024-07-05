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
<quiz01>

using System.Security.Cryptography;

//1단계
namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Random random = new Random();
            int[] number = new int[5];
            Console.Write("로또번호 : ");
            for (int i = 0; i < 5; i++)
            {
                number[i] = random.Next(1, 46);
                Console.Write($"{number[i]} ");
            }
         
            Console.WriteLine($"보너스번호 : {random.Next(1, 46)}");
        }
    }
}
//2단계

using System.Globalization;
using System.Security.Cryptography;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];
            Random random = new Random();

            for (int i = 0; i < 7; i++)
            {
                numbers[i] = random.Next(1, 46);
                //전수조사
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        i--;
                        break;
                    }
                }
            }

            int bonusNumber = numbers[6];
            int[] lottoNumbers = new int[6];
            Array.Copy(numbers, 0, lottoNumbers, 0, 6);

            Array.Sort(lottoNumbers);
            foreach (int i in lottoNumbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"보너스 번호 {bonusNumber}");

        }
    }
}
```
```
<로또 랜덤 뽑기 , 정렬 , 중복 x 교수님 정답>
namespace LottoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> LottoNumberList = new List<int>();
            while (LottoNumberList.Count < 7)
            {
                int number = random.Next(1, 46);

                if (!LottoNumberList.Contains(number))
                    LottoNumberList.Add(number);
            }
            //보너스 번호 뽑기 , 0번지 첫번째 요소를 보너스 번호로 하자.
            int bonusNumber = LottoNumberList[0];
            LottoNumberList.RemoveAt(0);
            //로또번호 6개만 정렬
            LottoNumberList.Sort();
            foreach (int i in LottoNumberList)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"보너스 번호 : {bonusNumber}");
        }
    }
}
```
```
<버블정렬>
namespace bubblesort01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 4, 5, 7, 3, 2, 1, 9, 8 };
            int temp;
            for (int i = 8 - 1; i >= 0; i--)
            {
                for (int k = 0; k < i ; k++)
                {
                    if (list[k] > list[k + 1])
                    {
                        temp = list[k];
                        list[k] = list[k + 1];
                        list[k + 1] = temp;
                    }
                }
            }
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
```
```
namespace propertyp1
{
    class Person
    {

        public string Name
        {
            get { return Name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("이름이 입력되지 않았습니다");
                }
                else
                {
                    Name = value;
                }
            }
        }
    }
    class Student
    {
        public string Name { get; set; } = "아무개";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "";
            Console.WriteLine(person.Name);
        }
    }
}
```
```
    namespace testapp02
{
    class User
    {
        private readonly string userID;
        private readonly string userPW;

        public User(string userID, string userPW)
        {
            this.userID = userID;
            this.userPW = userPW;
        }
        public void Print()
        {
            Console.WriteLine(this.userID);
            Console.WriteLine(this.userPW);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string uID = "abc";
            string uPW = "abc";
            User user = new User(uID, uPW);
            user.Print();
        }
    }
}
```
```
