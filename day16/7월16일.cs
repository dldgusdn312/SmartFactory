```
using Oracle.ManagedDataAccess.Client;

namespace OracleTest01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 외부 프로그램 연결 모듈 받기 -- nuGet 패키지
            //2. 연결 스크립트를 사용
            string strConn = "Data Source=(DESCRIPTION=" +
               "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
               "(HOST=localhost)(PORT=9000)))" +
               "(CONNECT_DATA=(SERVER=DEDICATED)" +
               "(SERVICE_NAME=xe)));" +
               "User Id=SCOTT;Password=TIGER;";

            // 1. 연결 객체 만들기
            OracleConnection conn = new OracleConnection(strConn);
            // 2. 데이터베이스 접속을 위한 연결
            conn.Open();
            // 3.프로그래밍
            //3.1 Query 명령객체 만들기
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn; //연결객체와 연동
            //3.2 명령하기, 테이블 생성하기
            cmd.CommandText = "Create Table PhoneBook " +
                "(ID number(4) PRIMARY KEY,  " +
                "NAME varchar(20), " +
                "HP varchar(20))";
            //3.3 쿼리 실행하기
            //cmd.ExecuteNonQuery();
            // 4. 리소스 반환 및 종료
            conn.Close();


        }
    }
}
```
