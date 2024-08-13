```
[차종 선택 레이아웃]
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Transactions;
using System.Windows.Forms;
using NumericApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NumericApp
{
    public partial class Cart : Form
    {
        private string connectionString = "User Id=scott;Password=tiger;" +
                                          "Data Source=(DESCRIPTION=" +
                                          "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                                          "(HOST=192.168.0.2)(PORT=1521)))" +
                                          "(CONNECT_DATA=(SERVER=DEDICATED)" +
                                          "(SERVICE_NAME=xe)));";

        public Cart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {


            // OracleConnection 객체 생성
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    // 연결 열기
                    conn.Open();

                    // 트랜잭션 시작
                    OracleTransaction transaction = conn.BeginTransaction();

                    // ListView에서 아이템 가져오기
                    foreach (ListViewItem item in listViewModelCar.Items)
                    {
                        string modelName = item.Text; // 첫 번째 열 (모델명)
                        string quantity = item.SubItems[1].Text; // 두 번째 열 (수량)

                        // SQL 쿼리 작성
                        string sql = "INSERT INTO ORDERCAR (차종모델, 주문수량, 주문날짜, 예상출고일) " +
                                     "VALUES (:modelName, :quantity, TO_CHAR(SYSDATE, 'YYYY/MM/DD HH24:MI:SS'),'공정대기중')";

                        // OracleCommand 객체 생성
                        using (OracleCommand cmd = new OracleCommand(sql, conn))
                        {
                            // 파라미터 추가
                            cmd.Parameters.Add(new OracleParameter("modelName", modelName));
                            cmd.Parameters.Add(new OracleParameter("quantity", quantity));

                            // 쿼리 실행
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 트랜잭션 커밋
                    transaction.Commit();

                    // 성공 메시지 표시
                    MessageBox.Show("주문이 완료되었습니다!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {


                    // 에러 메시지 표시
                    MessageBox.Show("에러발생: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void numericUpDownModel3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            listViewModelCar.Items.Clear();

            // NumericUpDown 컨트롤에서 값 가져오기
            int modelSCount = (int)numericUpDownModelS.Value;
            int model3Count = (int)numericUpDownModel3.Value;
            int modelXCount = (int)numericUpDownModelX.Value;
            int modelYCount = (int)numericUpDownModelY.Value;

            // 각 모델의 이름과 수량을 ListView에 추가합니다.
            if (modelSCount > 0)
            {
                ListViewItem item = new ListViewItem("테슬라 모델 S");  // 첫 번째 열에 모델 이름 추가
                item.SubItems.Add(modelSCount.ToString()); // 두 번째 열에 수량 추가
                listViewModelCar.Items.Add(item);
            }

            if (model3Count > 0)
            {
                ListViewItem item = new ListViewItem("테슬라 모델 3");
                item.SubItems.Add(model3Count.ToString());
                listViewModelCar.Items.Add(item);
            }

            if (modelXCount > 0)
            {
                ListViewItem item = new ListViewItem("테슬라 모델 X");
                item.SubItems.Add(modelXCount.ToString());
                listViewModelCar.Items.Add(item);
            }

            if (modelYCount > 0)
            {
                ListViewItem item = new ListViewItem("테슬라 모델 Y");
                item.SubItems.Add(modelYCount.ToString());
                listViewModelCar.Items.Add(item);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 항목이 삭제 됩니다.\r계속 하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (listViewModelCar.SelectedItems.Count > 0)
                {
                    int index = listViewModelCar.FocusedItem.Index;
                    listViewModelCar.Items.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("선택하신 항목이 없습니다.");
                }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
```
