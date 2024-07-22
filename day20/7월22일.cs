```
<시퀀스 도구 생성>
CREATE TABLE DEPT_SEQUENCE
AS SELECT * FROM DEPT WHERE 1<>1;
SELECT * FROM DEPT_SEQUENCE;
CREATE SEQUENCE SEQ_DEPT_SEQUENCE
INCREMENT BY 10
START WITH 10
MAXVALUE 90
MINVALUE 0
NOCYCLE
CACHE 2;

INSERT INTO DEPT_SEQUENCE (DEPTNO,DNAME,LOC) VALUES 
(SEQ_DEPT_SEQUENCE.NEXTVAL,'DATABASE','ANDONG');
SELECT * FROM DEPT_SEQUENCE;
SELECT SEQ_DEPT_SEQUENCE.CURRVAL FROM DUAL;
ALTER SEQUENCE SEQ_DEPT_SEQUENCE
INCREMENT BY 3
MAXVALUE 99
CYCLE;
```
```
<명함관리 퀴즈>
using Oracle.ManagedDataAccess.Client;

namespace businesscard2
{
    internal class Program

    {
        static void Main(string[] args)
        {
            string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=9000)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=SCOTT;Password=TIGER;";
            //1.연결 객체 만들기 - Client
            OracleConnection conn = new OracleConnection(strConn);
            //2.데이터베이스 접속을 위한 연결
            conn.Open();
            //명령객체 생성
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            int choice;
            do
            {
                Console.WriteLine("============================");
                Console.WriteLine("명함 관리 시스템");
                Console.WriteLine("============================");
                Console.WriteLine("1. 명함 추가");
                Console.WriteLine("2. 명함 목록 보기");
                Console.WriteLine("3. 명함 수정");
                Console.WriteLine("4. 명함 삭제");
                Console.WriteLine("5. 명함 검색");
                Console.WriteLine("6. 프로그램 종료");
                Console.WriteLine("============================");
                Console.WriteLine("선택");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("[명함 추가 기능]");
                        Console.WriteLine("============================");
                        Console.WriteLine("명함 추가");
                        Console.WriteLine("============================");
                        Console.WriteLine("ID번호 : ");
                        int a_1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("이름 : ");
                        string b_1 = Console.ReadLine();
                        Console.WriteLine("전화번호 : ");
                        string c_1 = Console.ReadLine();
                        Console.WriteLine("이메일 : ");
                        string d_1 = Console.ReadLine();
                        Console.WriteLine("회사 : ");
                        string e_1 = Console.ReadLine();
                        Console.WriteLine("주소 : ");
                        string f_1 = Console.ReadLine();
                        cmd.CommandText = $"INSERT INTO BUISINESSCARDS (ID, NAME, HP, EMAIL, COMPANY, ADDRESS) VALUES('{a_1}', '{b_1}', '{c_1}', '{d_1}', '{e_1}', '{f_1}')";
                        cmd.ExecuteNonQuery();

                        break;
                    case 2:
                        Console.WriteLine("[명함 목록 보기 기능]");
                        Console.WriteLine("============================");
                        Console.WriteLine("명함 목록");
                        Console.WriteLine("============================");
                        cmd.CommandText = "SELECT * FROM BUISINESSCARDS";
                        cmd.ExecuteNonQuery();
                        OracleDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {
                            int id = int.Parse(rdr["ID"].ToString());
                            string name = rdr["NAME"] as string;
                            string hp = rdr["HP"] as string;
                            string email = rdr["EMAIL"] as string;
                            string com = rdr["COMPANY"] as string;
                            string add = rdr["ADDRESS"] as string;
                            Console.WriteLine($"{id} | {name} | {hp} | {email} | {com} | {add} ");
                        }

                        break;
                    case 3:
                        Console.WriteLine("[명함 수정 화면]");
                        Console.WriteLine("============================");
                        Console.WriteLine("명함 수정");
                        Console.WriteLine("============================");
                        Console.Write("수정할 ID : ");
                        int a_2 = int.Parse(Console.ReadLine());
                        Console.Write("ID번호 : ");
                        int b_2 = int.Parse(Console.ReadLine());
                        Console.Write("이름 : ");
                        string c_2 = Console.ReadLine();
                        Console.Write("전화번호 : ");
                        string d_2 = Console.ReadLine();
                        Console.Write("이메일 : ");
                        string e_2 = Console.ReadLine();
                        Console.Write("회사 : ");
                        string f_2 = Console.ReadLine();
                        Console.Write("주소 : ");
                        string g_2 = Console.ReadLine();
                        cmd.CommandText = $"UPDATE BUISINESSCARDS SET ID = '{b_2}' , NAME = '{c_2}' , HP='{d_2}' , EMAIL = '{e_2}' , COMPANY = '{f_2}' , ADDRESS = '{g_2}' " +
                              $"WHERE ID = {a_2}";
                        cmd.ExecuteNonQuery();
                        break;

                    case 4:
                        Console.WriteLine("[명함 삭제 화면]");
                        Console.WriteLine("============================");
                        Console.WriteLine("명함 삭제");
                        Console.WriteLine("============================");
                        Console.Write("삭제할 ID : ");
                        int a_3 = int.Parse(Console.ReadLine());
                        cmd.CommandText = $"DELETE FROM BUISINESSCARDS WHERE ID = '{a_3}' ";
                        cmd.ExecuteNonQuery();
                        break;
                    case 5:

                        Console.WriteLine("[명함 검색 기능]");
                        Console.WriteLine("============================");
                        Console.WriteLine("명함 검색");
                        Console.WriteLine("============================");
                        Console.WriteLine("검색할 ID 번호를 입력하세요 : ");
                        int z_1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("============================");
                        Console.WriteLine("검색 결과");
                        cmd.CommandText = $"SELECT * FROM BUISINESSCARDS\r\n\r\nWHERE ID LIKE '{z_1}'";
                        cmd.ExecuteNonQuery();
                        OracleDataReader der = cmd.ExecuteReader();

                        while (der.Read())
                        {
                            int id = int.Parse(der["ID"].ToString());
                            string name = der["NAME"] as string;
                            string hp = der["HP"] as string;
                            string email = der["EMAIL"] as string;
                            string com = der["COMPANY"] as string;
                            string add = der["ADDRESS"] as string;
                            Console.WriteLine($"{id} | {name} | {hp} | {email} | {com} | {add} ");
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("시스템 종료");
                        Environment.Exit(0);
                        //4. 리소스 반환 및 종료
                        conn.Close();
                        break;
                    default:
                        Console.WriteLine("다시 입력해주세요");
                        break;
                }
            } while (choice != 6);
        }
    }
}

