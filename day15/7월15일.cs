```
<listtest>
using System.Runtime.Serialization;

namespace ObjectArray
{
    class Person
    {
        public string name;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[3] {"홍길동","이순신","강감찬" };
            List<char> list = new List<char>();
            list.Add('x');
            list.Add('y');
            list.Add('z');

            Person[] persons = new Person[2];
            Person p1 = new Person();
            p1.name = "홍길동";
            persons[0] = p1;

            Person p2 = new Person();
            p2.name = "이순신";
            persons[1] = p2;

            List<Person> list2 = new List<Person>();
            Person p3 = new Person();
            p3.name = "홍길동";
            list2.Add(p3);

            Person p4 = new Person();
            p4.name = "이순신";
            list2.Add(p4);


            foreach (Person p in list2)
            {
                Console.WriteLine(p.name);

            }
        }
    }
}
```
```
using System.Collections.Generic;

namespace Listobject1
{
    class Student
    {
        public string Name { get; set; }

    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[3] { "이순신", "강감찬", "을지문덕" };
            List<Student>studentList = new List<Student>();

            Student st1 = new Student();
            st1.Name = "이순신";
            Student st2 = new Student();
            st1.Name = "강감찬";
            Student st3 = new Student();
            st1.Name = "을지문덕";

            studentList.Add(st1);
            studentList.Add(st2);
            studentList.Add(st3);

            foreach (Student st in studentList)
            {
                Console.WriteLine(st.Name);
            }

        }
    }
}
```
```
<quiz1>
using System.Collections.Generic;

namespace Listobject1
{
    class Car
    {
        public string Brand { get; set; }
        public int Speed {  get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<Car>carList = new List<Car>();

            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
            car1.Brand = "현대";
            car1.Speed = 300;
            
            car2.Brand = "기아";
            car2.Speed = 280;
           
            car3.Brand = "BMW";
            car3.Speed = 290;

            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);

            foreach (Car i in carList)
            {
                Console.WriteLine(i.Brand);
                Console.WriteLine(i.Speed);
            }

        }
    }
}
```
```
<quiz2>
//using Microsoft.VisualBasic;

using System.Runtime.CompilerServices;

namespace DateTimequiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("년도 : ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("월 : ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("일 : ");
            int day = int.Parse(Console.ReadLine());

            DateTime dateTime = new DateTime(year, month, day);
            Console.WriteLine($"입력한 날짜 : {dateTime.ToString("yyyy-MM-dd")}");
            DateTime Now = DateTime.Now;
            Console.WriteLine($"현재 시간 : {Now.ToString("yyyy-MM-dd HH:mm:ss")}");

            //교수님 방식
            Console.WriteLine();
            Console.Write("입력한 날짜 : ");
            string time = new DateTime(year, month, day).ToString("yyyy-MM-dd");
            Console.WriteLine(time);
            Console.Write("현재 시간 : ");
            String currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(currentTime);
        }
    }
}

        }
    }
}
```
```
