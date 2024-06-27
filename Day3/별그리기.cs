[1단계]

namespace gugudan

{

    internal class Program

    {

        static void Main(string[] args)

        {

            for (int i = 1; i <= 5; i++)

            {

                for (int j = 1; j <= i; j++)

                    Console.Write("*");

                Console.WriteLine();

            }

        }

    }

}

[2단계]

namespace gugudan

{

    internal class Program

    {

        static void Main(string[] args)

        {

            for (int i = 5; i >= 1; i--)

            {

                for (int j = 1; j <= i; j++)

                    Console.Write("*");

                Console.WriteLine();



            }

        }

    }

}

[3단계]

namespace gugudan

{

    internal class Program

    {

        static void Main(string[] args)

        {

            for (int i = 0; i <= 5; i++)

            {

                for (int j = 5; j > 0; j--)

                {

                    if (i >= j)

                        Console.Write("*");

                    else

                    {

                        Console.Write(" ");

                    }

                }

                Console.WriteLine();

            }

        }

    }

}

[4단계]

namespace gugudan

{

    internal class Program

    {

        static void Main(string[] args)

        {

            for (int i = 0; i < 5; i++)

            {

                for (int j = 0; j < 5; j++)

                {

                    if (j >= i)

                        Console.Write("*");

                    else

                    {

                        Console.Write(" ");

                    }

                }

                Console.WriteLine();

            }

        }

    }

}
