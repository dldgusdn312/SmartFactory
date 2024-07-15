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
