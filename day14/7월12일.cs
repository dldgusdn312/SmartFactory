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
namespace ListTestApp02
{
    class Album
    {
        //private int no;
        //private string title;
        //private stirng artist;
        public int No { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }


    }
    class NewjeansAlbum : Album
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NewjeansAlbum> albumList = new List<NewjeansAlbum>();
            NewjeansAlbum album = new NewjeansAlbum();
            album.No = 1;
            album.Title = "hypeboy";
            album.Artist = "뉴진스";
            Console.WriteLine(album.No);
            Console.WriteLine(album.Title);
            Console.WriteLine(album.Artist);
            albumList.Add(album);

            album = new NewjeansAlbum();
            album.No = 2;
            album.Title = "super shy";
            album.Artist = "뉴진스";
            albumList.Add(album);

            //album = new NewjeansAlbum(3,"ETA","해린");
            //albumList.Add(album);

            foreach(NewjeansAlbum na in albumList)
            {
                Console.WriteLine(na.No);
                Console.WriteLine(na.Title);
                Console.WriteLine(na.Artist);
                Console.WriteLine();
            }


        }
    }
}
```
```
<quiz3>
namespace ConsoleApp17
{
    class Person
    {
        //private int id;
        //private string name;
        //private string hp;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Hp { get; set; }

        public Person(int id, string name, string hp)
        {
            Id = id;
            Name = name;
            Hp = hp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> addressbook = new List<Person>();

            int choice = 0;
            do
            {
                Console.WriteLine("1. 데이터 삽입");
                Console.WriteLine("2. 데이터 삭제");
                Console.WriteLine("3. 데이터 수정");
                Console.WriteLine("4. 데이터 검색");
                Console.WriteLine("5. 프로그램 종료");
                Console.WriteLine();
                Console.Write("메뉴 : ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("삽입");
                        Console.Write("ID 번호를 입력하세요. :");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("이름을 입력하세요. :");
                        string name = Console.ReadLine();
                        Console.Write("전화번호를 입력하세요. :");
                        string hp = Console.ReadLine();
                        Person person = new Person(id, name, hp);
                        addressbook.Add(person);
                        

                        break;
                    case 2:
                        Console.WriteLine("삭제");
                        break;
                    case 3:
                        Console.WriteLine("수정");
                        break;
                    case 4:
                        Console.WriteLine("검색");
                        foreach(Person p in addressbook)
                        {
                            Console.WriteLine($"ID : {p.Id}");
                            Console.WriteLine($"NAME : {p.Name}");
                            Console.WriteLine($"HP : {p.Hp}");
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.WriteLine("종료");
                        break;
                        default:
                        Console.WriteLine("다시 시작해 주세요.");
                        break;
                }
                Console.WriteLine();

            } while (choice != 5) ;
        }
    }
}
```
```
<주소록 만들기>
namespace ConsoleApp17
{
    class Person
    {
        //private int id;
        //private string name;
        //private string hp;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hp { get; set; }

        public Person(int id, string name, string hp)
        {
            Id = id;
            Name = name;
            Hp = hp;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> addressbook = new List<Person>(); //리스트 만들기

            //do ~ while 메뉴 do{
            int choice = 0;
            do
            {
                Console.WriteLine("1. 데이터 삽입");
                Console.WriteLine("2. 데이터 삭제");
                Console.WriteLine("3. 데이터 수정");
                Console.WriteLine("4. 데이터 검색");
                Console.WriteLine("5. 프로그램 종료");
                Console.WriteLine();
                Console.Write("메뉴 : ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("삽입");
                        Console.Write("ID 번호를 입력하세요 : ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("이름을 입력하세요 : ");
                        string name = Console.ReadLine();
                        Console.Write("전화번호를 입력하세요 : ");
                        string hp = Console.ReadLine();
                        Person person = new Person(id, name, hp);
                        addressbook.Add(person);
                        break;
                    case 2:
                        Console.WriteLine("삭제");
                        Console.Write("삭제할 데이터의 ID를 입력해 주세요.");
                        int deleteId = int.Parse(Console.ReadLine());

                        for (int i = 0; i < addressbook.Count; i++)
                        {
                            if (addressbook[i].Id == deleteId)
                            {
                                addressbook.RemoveAt(i);
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("수정");
                        Console.Write("수정할 데이터의 ID를 입력해 주세요.");
                        int updateId = int.Parse(Console.ReadLine());

                        for (int i = 0; i < addressbook.Count; i++)
                        {
                            if (addressbook[i].Id == updateId)
                            {
                                
                                Console.Write("수정 ID 번호를 입력하세요 : ");
                                addressbook[i].Id = int.Parse(Console.ReadLine());
                                Console.Write("수정 이름을 입력하세요 : ");
                                addressbook[i].Name = Console.ReadLine();
                                Console.Write("수정 전화번호를 입력하세요 : ");
                                addressbook[i].Hp = Console.ReadLine();
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("검색");
                        foreach (Person p in addressbook)
                        {
                            Console.WriteLine($"ADDR_ID : {p.Id}");
                            Console.WriteLine($"이름 : {p.Name}");
                            Console.WriteLine($"전화번호 : {p.Hp}");
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.WriteLine("종료");
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
            } while (choice != 5);

        }
    }
}
```
```
