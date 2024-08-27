```
<나의 주문현황 확인>
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace CheckOrderStatus
{
    public partial class Form1 : Form
    {
        private string connectionString = "User Id=scott;Password=tiger;" +
                                          "Data Source=(DESCRIPTION=" +
                                          "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                                          "(HOST=192.168.0.2)(PORT=1521)))" +
                                          "(CONNECT_DATA=(SERVER=DEDICATED)" +
                                          "(SERVICE_NAME=xe)));";

        private Dictionary<string, string> carModelImageMap = new Dictionary<string, string>()
        {
            { "테슬라 모델 3", @"테슬라 모델 사진\테슬라 3.png" },
            { "테슬라 모델 S", @"테슬라 모델 사진\테슬라 S.png"  },
            { "테슬라 모델 X", @"테슬라 모델 사진\테슬라 X.png"  },
            { "테슬라 모델 Y", @"테슬라 모델 사진\테슬라 Y.png" }
        };
        public Form1()
        {
            InitializeComponent();
            // 셀 클릭 이벤트 핸들러 등록
            dataGridView1.CellClick += DataGridView1_CellClick;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonShowOrderData_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM ORDERCAR ORDER BY 주문날짜";
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 사용자가 유효한 행을 클릭했는지 확인
            if (e.RowIndex >= 0)
            {
                // 선택된 행 가져오기
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // 선택된 행에서 차종모델 추출
                string carModel = row.Cells["차종모델"].Value.ToString();

                // 차종모델이 딕셔너리에 존재하는지 확인
                if (carModelImageMap.ContainsKey(carModel))
                {
                    // 애플리케이션의 기본 디렉토리 가져오기
                    string basePath = AppDomain.CurrentDomain.BaseDirectory;

                    // 이미지 파일의 상대 경로 가져오기
                    string relativePath = carModelImageMap[carModel];

                    // 기본 경로와 상대 경로를 결합하여 전체 경로 얻기
                    string imagePath = Path.Combine(basePath, relativePath);

                    // 이미지 파일이 존재하는지 확인
                    if (File.Exists(imagePath))
                    {
                        // PictureBox에 이미지를 로드하여 표시
                        pictureBox1.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        MessageBox.Show("이미지 파일이 존재하지 않습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("해당 차종모델의 이미지를 찾을 수 없습니다.");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
```
