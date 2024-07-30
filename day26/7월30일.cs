```

namespace BoxingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 number1 = 0;
            int number2 = 100;

            Double number3 = 3.14;
            double number4 = 31.4159;

            number1 = number2;
            Console.WriteLine(number1);

            number2 = number1;
            Console.WriteLine(number2);

            number3 = number4;
            number4 = number3;

            char ch1 = 'A';
            char ch2 = 'B';
            ch1 = ch2;
            ch2 = ch1;

            float f1 = 3.14F;
            Double f2 = f1;
            f1 = (float)f2;
            
        }
    }
}
```
```
using System.Text;

namespace BoxingApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 42;
            //Int32 boxed = number; //Boxing
            //int unboxed = boxed; //Unboxing

            //object obj = number; //UpCasting, Boxing
            //int downed = (int)obj; //강제형변환, DownCasting
            string str1 = "Hello World";
            string str2 = new string("Hello World");
            string str3 = "Hello World";
            string str4 = "Hello World";
            string str5 = new string("Hello World");

            object obj1 = new object();
            object obj2 = new object();

            StringBuilder sb1 = new StringBuilder("gd");
            StringBuilder sb2 = new StringBuilder("gd");

            Console.WriteLine($"str1 : {str1.GetHashCode()}");
            Console.WriteLine($"str2 : {str2.GetHashCode()}");
            Console.WriteLine($"str3 : {str3.GetHashCode()}");
            Console.WriteLine($"str4 : {str4.GetHashCode()}");
            Console.WriteLine($"str5 : {str5.GetHashCode()}");
            Console.WriteLine();
            Console.WriteLine($"obj1 : {obj1.GetHashCode()}");
            Console.WriteLine($"obj2 : {obj2.GetHashCode()}");
            Console.WriteLine($"sb1 : {sb1.GetHashCode()} {sb1.ToString()}");
            Console.WriteLine($"sb1 : {sb2.GetHashCode()} {sb2.ToString()}");


        }
    }
}
```
```
