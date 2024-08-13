```
<차종 모델 조회>
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace carinfo
{
    public partial class ViewOption : Form
    {
        private string connectionString = "User Id=scott;Password=tiger;" +
                                  "Data Source=(DESCRIPTION=" +
                                  "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                                  "(HOST=192.168.0.2)(PORT=1521)))" +
                                  "(CONNECT_DATA=(SERVER=DEDICATED)" +
                                  "(SERVICE_NAME=xe)));";
        public ViewOption()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sh = @"테슬라 모델 사진\s_1.png";
            pictureBox1.Image = Image.FromFile(sh);
            string bh = @"테슬라 모델 사진\3_1.png";
            pictureBox2.Image = Image.FromFile(bh);
            string xh = @"테슬라 모델 사진\x_1.png";
            pictureBox3.Image = Image.FromFile(xh);
            string yh = @"테슬라 모델 사진\y_1.png";
            pictureBox4.Image = Image.FromFile(yh);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string selectedModel = comboBox1.SelectedItem?.ToString();
            string query = "";

            if (!string.IsNullOrEmpty(selectedModel))
            {
                // 선택된 모델에 따라 쿼리 작성
                switch (selectedModel)
                {
                    case "Model S":
                        query = "SELECT SORTATION, MODEL_S FROM CARINFO";
                        break;
                    case "Model 3":
                        query = "SELECT SORTATION, MODEL_3 FROM CARINFO";
                        break;
                    case "Model X":
                        query = "SELECT SORTATION, MODEL_X FROM CARINFO";
                        break;
                    case "Model Y":
                        query = "SELECT SORTATION, MODEL_Y FROM CARINFO";
                        break;
                }

                // 쿼리를 실행하여 데이터 로드
                LoadCarSpecifications(query);
            }
            else
            {
                MessageBox.Show("차량 모델을 선택해 주세요.");
            }
        }
            private void LoadCarSpecifications(string query)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleDataAdapter adapter = new OracleDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // DataGridView에 데이터 설정
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("데이터베이스에서 정보를 불러오는 도중 오류가 발생했습니다: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                // 콤보박스 선택이 바뀔 때마다 이미지를 업데이트
                UpdateCarImages();
            }
        }
            private void UpdateCarImages()
            {
                // ComboBox에서 선택된 모델을 가져옴
                string selectedModel = comboBox1.SelectedItem?.ToString();

                // 선택된 모델에 따라 해당 PictureBox에 이미지 파일 경로를 설정
                switch (selectedModel)
                {
                
                    case "Model S":
                        pictureBox1.Image = Image.FromFile(@"테슬라 모델 사진\s.png");
                        pictureBox2.Image = Image.FromFile(@"테슬라 모델 사진\3_1.png");
                        pictureBox3.Image = Image.FromFile(@"테슬라 모델 사진\x_1.png");
                        pictureBox4.Image = Image.FromFile(@"테슬라 모델 사진\y_1.png");
                        break;
                    case "Model 3":
                        pictureBox1.Image = Image.FromFile(@"테슬라 모델 사진\s_1.png");
                        pictureBox2.Image = Image.FromFile(@"테슬라 모델 사진\3.png");
                        pictureBox3.Image = Image.FromFile(@"테슬라 모델 사진\x_1.png");
                        pictureBox4.Image = Image.FromFile(@"테슬라 모델 사진\y_1.png");
                        break;
                    case "Model X":
                        pictureBox1.Image = Image.FromFile(@"테슬라 모델 사진\s_1.png");
                        pictureBox2.Image = Image.FromFile(@"테슬라 모델 사진\3_1.png");
                        pictureBox3.Image = Image.FromFile(@"테슬라 모델 사진\x.png");
                        pictureBox4.Image = Image.FromFile(@"테슬라 모델 사진\y_1.png");
                        break;
                    case "Model Y":
                        pictureBox1.Image = Image.FromFile(@"테슬라 모델 사진\s_1.png");
                        pictureBox2.Image = Image.FromFile(@"테슬라 모델 사진\3_1.png");
                        pictureBox3.Image = Image.FromFile(@"테슬라 모델 사진\x_1.png");
                        pictureBox4.Image = Image.FromFile(@"테슬라 모델 사진\y.png");
                        break;
                }
            }
        }
}
```
