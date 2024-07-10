```
namespace ArrayTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];//선언과 동시 초기화

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 13 * (i + 1);
                Console.WriteLine(numbers[i]);
            }
            string[] names = new string[3];
            for (int j = 0; j < numbers.Length; j++)
            {
                names[j] = Console.ReadLine();
            }
                Console.WriteLine(numbers[j]);
            }
        }
    }
```
```
namespace ConsoleApp14
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "아무개";
        public string Major { get; set; } = "공통학부";
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Student[] students = new Student[3];
                Student s1 = new Student();
                Student s2 = new Student();
                Student s3 = new Student();

                students[0] = s1;
                students[1] = s2;
                students[2] = s3;

                s1.Id = 1;
                s1.Name = "홍길동";
                s1.Major = "컴퓨터공학과";

                s2.Id = 2;
                s2.Name = "이순신";
                s2.Major = "기계설계공학과";

                s3.Id = 3;
                s3.Name = "이현우";
                s3.Major = "정보통신공학과";

                foreach (Student s in students)
                {
                    Console.WriteLine(s.Id);
                    Console.WriteLine(s.Name);
                    Console.WriteLine(s.Major);
                }
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine(students[i].Id);
                    Console.WriteLine(students[i].Name);
                    Console.WriteLine(students[i].Major);
                }
            }
        }
    }
```
```
namespace ParamsTest
{
    internal class Program
    {
        static void TestMethod(double[] arr)
        {

        }
        static int TotalSum(params int[] myArray)
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            double[] arr2 = {1,2,3};
            TestMethod(arr2);
            //TestMethod(1,2,3,4,5);
            //TotalSum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine(TotalSum(1,2,3,4,5,6,7,8,9,10));
            Console.WriteLine(TotalSum(1,3,5,7,9));
        }
    }
}
```
```
