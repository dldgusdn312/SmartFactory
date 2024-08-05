```
[안동대 2024][1일] 콘솔 상품, 공장 관련 Console, DB 프로그램 작성
using Oracle.ManagedDataAccess.Client;
using System;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oracle DB 연결 문자열 설정
            string strConn = "Data Source=(DESCRIPTION=" +
                             "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                             "(HOST=localhost)(PORT=9000)))" +
                             "(CONNECT_DATA=(SERVER=DEDICATED)" +
                             "(SERVICE_NAME=xe)));" +
                             "User Id=SCOTT;Password=TIGER;";

            // 연결 객체 생성 및 DB 연결
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            int choice;

            do
            {
                Console.WriteLine("[라면 공장]");
                Console.WriteLine("=====================");
                Console.WriteLine("1. 제품 추가");
                Console.WriteLine("2. 제품 검색");
                Console.WriteLine("3. 제품 수정");
                Console.WriteLine("4. 제품 삭제");
                Console.WriteLine("5. 제품 조회");
                Console.WriteLine();
                Console.WriteLine("6. 생산 기록 추가");
                Console.WriteLine("7. 생산 기록 조회");
                Console.WriteLine("8. 프로그램 종료");
                Console.WriteLine();
                Console.WriteLine("=====================");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        // 제품 추가
                        Console.WriteLine("제품명을 입력하세요:");
                        string name = Console.ReadLine();
                        Console.WriteLine("가격을 입력하세요:");
                        int price = int.Parse(Console.ReadLine());
                        Console.WriteLine("재고 수량을 입력하세요:");
                        int stock = int.Parse(Console.ReadLine());

                        cmd.CommandText = $"INSERT INTO Product(ProductID, Name, Price, Stock) " +
                                          $"VALUES (SEQ_PRODUCT.NEXTVAL, '{name}', {price}, {stock})";
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("제품이 추가되었습니다.");
                        break;

                    case 2:
                        // 제품 검색
                        Console.WriteLine("검색할 제품 ID를 입력하세요:");
                        int searchId = int.Parse(Console.ReadLine());
                        cmd.CommandText = $"SELECT * FROM Product WHERE ProductID = {searchId}";

                        OracleDataReader odr = cmd.ExecuteReader();
                        while (odr.Read())
                        {
                            int id = odr.GetInt32(0);
                            name = odr["Name"] as string;
                            price = odr.GetDecimal(2);
                            stock = odr.GetInt32(3);

                            Console.WriteLine($"ID: {id}, 제품명: {name}, 가격: {price}, 재고: {stock}");
                        }
                        odr.Close();
                        break;

                    case 3:
                        // 제품 수정
                        Console.WriteLine("수정할 제품 ID를 입력하세요:");
                        int updateId = int.Parse(Console.ReadLine());
                        Console.WriteLine("수정할 제품명을 입력하세요:");
                        name = Console.ReadLine();
                        Console.WriteLine("수정할 가격을 입력하세요:");
                        price = int.Parse(Console.ReadLine());
                        Console.WriteLine("수정할 재고 수량을 입력하세요:");
                        stock = int.Parse(Console.ReadLine());

                        cmd.CommandText = $"UPDATE Product SET " +
                                          $"Name = '{name}', Price = {price}, Stock = {stock} " +
                                          $"WHERE ProductID = {updateId}";
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("제품이 수정되었습니다.");
                        break;

                    case 4:
                        // 제품 삭제
                        Console.WriteLine("삭제할 제품 ID를 입력하세요:");
                        int deleteId = int.Parse(Console.ReadLine());
                        Console.WriteLine("정말 삭제하시겠습니까? (Y/N)");
                        string sure = Console.ReadLine();

                        if (sure.ToLower() == "y")
                        {
                            cmd.CommandText = $"DELETE FROM Product WHERE ProductID = {deleteId}";
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("제품이 삭제되었습니다.");
                        }
                        break;

                    case 5:
                        // 제품 조회
                        cmd.CommandText = "SELECT * FROM Product";
                        OracleDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {
                            int id = rdr.GetInt32(0);
                            name = rdr["Name"] as string;
                            price = rdr.GetDecimal(2);
                            stock = rdr.GetInt32(3);
                            Console.WriteLine($"ID: {id}, 제품명: {name}, 가격: {price}, 재고: {stock}");
                        }
                        rdr.Close();
                        break;

                    case 6:
                        // 생산 기록 추가
                        Console.WriteLine("생산할 제품 ID를 입력하세요:");
                        int prodId = int.Parse(Console.ReadLine());
                        Console.WriteLine("생산 수량을 입력하세요:");
                        int quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("생산 날짜를 입력하세요 (YYYY-MM-DD):");
                        DateTime prodDate = DateTime.Parse(Console.ReadLine());

                        cmd.CommandText = $"INSERT INTO Production(ProductionID, ProductID, Quantity, ProductionDate) " +
                                          $"VALUES (SEQ_PRODUCTION.NEXTVAL, {prodId}, {quantity}, TO_DATE('{prodDate:yyyy-MM-dd}', 'YYYY-MM-DD'))";
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("생산 기록이 추가되었습니다.");
                        break;

                    case 7:
                        // 생산 기록 조회
                        cmd.CommandText = "SELECT P.ProductionID, P.ProductID, Pr.Name, P.Quantity, P.ProductionDate " +
                                          "FROM Production P JOIN Product Pr ON P.ProductID = Pr.ProductID";
                        OracleDataReader prodReader = cmd.ExecuteReader();

                        while (prodReader.Read())
                        {
                            int productionId = prodReader.GetInt32(0);
                            prodId = prodReader.GetInt32(1);
                            name = prodReader["Name"] as string;
                            quantity = prodReader.GetInt32(3);
                            DateTime prodDateResult = prodReader.GetDateTime(4);
                            Console.WriteLine($"생산 기록 ID: {productionId}, 제품 ID: {prodId}, 제품명: {name}, 수량: {quantity}, 날짜: {prodDateResult:yyyy-MM-dd}");
                        }
                        prodReader.Close();
                        break;

                    case 8:
                        Console.WriteLine("프로그램을 종료합니다.");
                        break;
                }
            } while (choice != 8);

            // DB 연결 종료
            conn.Close();
        }
    }
}
```
```
[Oracle code]
CREATE TABLE Product (
    ProductID NUMBER PRIMARY KEY,
    Name VARCHAR2(50) NOT NULL,
    Price NUMBER NOT NULL,
    Stock NUMBER NOT NULL
);
CREATE TABLE Production (
    ProductionID NUMBER PRIMARY KEY,
    ProductID NUMBER,
    Quantity NUMBER NOT NULL,
    ProductionDate DATE NOT NULL,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID) ON DELETE CASCADE
);
CREATE SEQUENCE SEQ_PRODUCT START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE SEQ_PRODUCTION START WITH 1 INCREMENT BY 1;
SELECT * FROM Product;
SELECT * FROM Production;
```
```
<datagridview01>
using System.Windows.Forms;

namespace DataGridViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.Columns.Add("ID", "번호");
            dataGridView.Columns.Add("NAME", "이름");
            dataGridView.Columns.Add("HP", "전화번호");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(tbID.Text,tbNAME.Text,tbHP.Text);
            dataGridView.Rows.Add("1", "홍길동", "010-1111-1111");
            dataGridView.Rows.Add("2", "이순신", "010-2222-2222");
            dataGridView.Rows.Add("3", "이현우", "010-3333-3333");
        }
    }
}
```
```
<datagridview02>
namespace DataGridViewApp02
{
    class Student
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string HP { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dataList = new List<Student>()
            {
                new Student { No = "1", Name = "홍길동", HP = "010-1111-1111" },
                new Student { No = "2", Name = "이순신", HP = "010-2222-2222" },
                new Student { No = "3", Name = "강감찬", HP = "010-3333-3333" }
               };
             dataGridView1.DataSource = dataList;
            }
        }
}
```
```
