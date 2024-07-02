```
<do~while문 구구단 3단>
namespace dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine($"3 * {i} = {3*i} ");
                i++;
            } while (i<10);
            }
        }
    }
```
```
<quiz01 메뉴 만들기(do~while)>
namespace dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("[메뉴 선택]");
                Console.WriteLine("1. 데이터베이스 입력");
                Console.WriteLine("2. 데이터베이스 검색");
                Console.WriteLine("3. 데이터베이스 수정");
                Console.WriteLine("4. 데이터베이스 삭제");
                Console.WriteLine("5. 프로그램 종료");
                Console.Write("선택 : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("데이터베이스 입력을 선택하셨습니다");
                        break;
                    case 2:
                        Console.WriteLine("데이터베이스 검색을 선택하셨습니다");
                        break;
                    case 3:
                        Console.WriteLine("데이터베이스 수정을 선택하셨습니다");
                        break;
                    case 4:
                        Console.WriteLine("데이터베이스 삭제를 선택하셨습니다");
                        break;
                    case 5:
                        Console.WriteLine("프로그램 종료를 선택하셨습니다");
                        break;
                    default:
                        Console.WriteLine("잘못 입력 하셨습니다");
                        break;
                }
                } while (choice != 5);
            } 
        }
    }
```
```
