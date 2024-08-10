```
<로그인 창 만들기 및 SQL 테이블에 연동하기>
namespace Login
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Oracle.ManagedDataAccess.Client;
    public partial class Form1 : Form
    {
        private string connectionString = "User Id=SCOTT;Password=TIGER;" +
                          "Data Source=(DESCRIPTION=" +
                          "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                          "(HOST=Localhost)(PORT=9000)))" +
                          "(CONNECT_DATA=(SERVER=DEDICATED)" +
                          "(SERVICE_NAME=xe)));";
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginid = textBox1.Text.Trim();  // Trim()으로 공백 제거
            string loginpwd = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(loginid) || string.IsNullOrEmpty(loginpwd))
            {
                MessageBox.Show("아이디와 비밀번호를 입력해 주세요.");
                return;
            }

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    // SQL 서버와 연결.
                    // Server = localhost : 로컬 호스트 (내 컴퓨터) 서버와 연결
                    // Database = 스키마 이름
                    // Uid = DB 로그인 아이디
                    // Pwd = DB 로그인 비밀번호
                    string selectQuery = "SELECT COUNT(*) FROM account WHERE id = :id AND pwd = :pwd";

                    using (OracleCommand command = new OracleCommand(selectQuery, connection))
                    {
                        command.Parameters.Add(new OracleParameter("id", loginid));
                        command.Parameters.Add(new OracleParameter("pwd", loginpwd));

                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("로그인 완료!");
                        }
                        else
                        {
                            MessageBox.Show("아이디 또는 비밀번호가 잘못되었습니다.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("로그인 중 오류가 발생했습니다: " + ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                Form2 showform2 = new Form2();
                showform2.ShowDialog();
            
        }
    }
```
```
  <회원가입 창 만들기 및 SQL 테이블 연동하기>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Login
{
    public partial class Form2 : Form
    {
        private string connectionString = "User Id=SCOTT;Password=TIGER;" +
                          "Data Source=(DESCRIPTION=" +
                          "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                          "(HOST=Localhost)(PORT=9000)))" +
                          "(CONNECT_DATA=(SERVER=DEDICATED)" +
                          "(SERVICE_NAME=xe)));";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string id = textBox2.Text;
            string pwd = textBox3.Text;

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO ACCOUNT (name, id, pwd) VALUES (:name, :id, :pwd)";


                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        command.Parameters.Add(new OracleParameter("name", textBox1.Text));
                        command.Parameters.Add(new OracleParameter("id", textBox2.Text));
                        command.Parameters.Add(new OracleParameter("pwd", textBox3.Text));

                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show(textBox1.Text + "님 회원가입 완료, 사용할 아이디는 " + textBox2.Text + "입니다.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("비정상 입력 정보, 재확인 요망");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("회원가입 중 오류가 발생했습니다: " + ex.Message);
            }
 
        }
    }
}
```
