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
<quiz02 콘솔 롤플레잉게임 - 용사의 서막>
namespace dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playname;
            int choice;
            Console.Write("닉네임을 입력하세요 : ");
            playname = Console.ReadLine();
            do
            {
                Console.Write($"안녕하세요, 용감한 탐험가 {playname}님 ");
                Console.WriteLine("드디어 떠나는 모험의 첫 걸음을 내딛게 되었군요.");
                Thread.Sleep(1000);
                Console.WriteLine("먼 길을 험난한 여정을 앞두고 있지만,");
                Thread.Sleep(1000);
                Console.WriteLine("용기와 지혜로 모든 위기를 헤쳐나가길 바랍니다.");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("다음은 플레이어가 선택할 수 있는 첫 번째 메뉴입니다.");
                Thread.Sleep(1000);

                Console.WriteLine("[메뉴 선택]");
                Console.WriteLine("1. 낡은 마을 탐험");
                Console.WriteLine("2. 숲 속 오두막 방문");
                Console.WriteLine("3. 게임 종료");
                Console.Write("선택 : ");
                choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("플레이어가 낡은 마을에 도착합니다.");
                            Thread.Sleep(1000);
                        Console.WriteLine("마을 주민들과 대화하고, 마을의 비밀을 파헤칠 수 있는 단서를 얻습니다.");
                            Thread.Sleep(1000);
                        Console.WriteLine("마을의 문제를 해결하기 위해 퀘스트를 수행해야 할 수도 있습니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("퀘스트를 완료하면 보상을 받을 수 있습니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("플레이어가 숲 속 오두막에 도착합니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("오두막에는 은둔하는 마법사가 살고 있습니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("마법사로부터 새로운 기술을 배우거나, 아이템을 구입할 수 있습니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine("마법사는 플레이어의 여정에 중요한 조언을 해줄 수도 있습니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("게임을 종료합니다.");
                        break;
                        default:
                        Console.WriteLine("잘못 입력 하셨습니다.");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        break;
                    }
                } while (choice != 3);
            } 
        }
    }
```
