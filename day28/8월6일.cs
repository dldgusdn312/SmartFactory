```
<연습문제>
namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        int Sajin = 1;
        int Sajin_Max = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/ㅎㅎ/" + Sajin + ".jpg");
            Sajin++;
            if (Sajin > Sajin_Max)
                Sajin = 1;
        }
    }
}
```
```
<TrackBar를 이용한 RGB 표현>
namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBarR.Value = 100;
            trackBarG.Value = 100;
            trackBarB.Value = 100;
        }

        private void trackBarR_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBarG_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
        //사용자 정의 함수
        private void UpdateColor()
        {
            int red = trackBarR.Value;
            int green = trackBarG.Value;
            int blue = trackBarB.Value;
            pictureBox1.BackColor = Color.FromArgb(red, green, blue);

        }
    }
}
```
```
<ProgressBar를 진행도 표현>
namespace ProgressBar
{
    public partial class Form1 : Form
    {
        private int progressValue;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = 100;
            //progressBar1.Value = 0;
            progressLabel.Text = "진행도 : 0%";
            //timer1.Interval = 100;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //progressValue = 0;
            //progressBar1.Value = 0;
            //progressLabel.Text = "진행도 : 0%";
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressValue += 1;
            if (progressValue <= 100)
            {
                progressBar1.Value = progressValue;
                progressLabel.Text = $"진행도 : {progressValue}%";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("진행 완료!");
            }
        }
    }
}
```
```
<데이터그리뷰 응용>
using System.Buffers;
using System.Xml.Linq;

namespace DataGridapp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("No", "번호");
            dataGridView1.Columns.Add("Name", "이름");
            dataGridView1.Columns.Add("HP", "핸드폰번호");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string no = textBoxNo.Text;
            string name = textBoxName.Text;
            string hp = textBoxHP.Text;


            if (!string.IsNullOrEmpty(no) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(hp))
            {
                dataGridView1.Rows.Add(no, name, hp);
                textBoxNo.Clear();
                textBoxName.Clear();
                textBoxHP.Clear();
            }
            else
            {
                MessageBox.Show("모든 필드를 입력해 주세요.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text;
            bool found = false;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows) //선택된 row에서 동일한 이름의 값을 찾음 
            {
                if (row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString().Equals(searchValue))
                {
                    row.Selected = true;
                    found = true;
                    MessageBox.Show("찾았습니다.");
                    return;
                }

            }
            if (!found)
                MessageBox.Show("해당 이름이 없습니다!");
        }
    }
}
```
```
<AccessForm 배우기>
<Form1 code>
namespace AccessForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this, "안녕하세요");
            frm2.ShowDialog();
        }
    }
}
```
```
<Form2 code>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessForm
{
    public partial class Form2 : Form
    {
        private Form1 frm1;
        private string str;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(object frm)
        {
            InitializeComponent();
            frm1 = (Form1)frm;
        }
        public Form2(object frm, string _str)
        {
            InitializeComponent();
            frm1 = (Form1)frm;
            str = _str;
        }

        private void btnChangeMainLabel_Click(object sender, EventArgs e)
        {
            frm1.label1.Text = "Form2에서 변경함.";
        }
    }
}
```
```
