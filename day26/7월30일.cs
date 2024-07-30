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
