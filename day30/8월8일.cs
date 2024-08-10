```
<테슬라 초기화면>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Button button = new Button
            {
                Text = "차종 선택",
                Size = new Size(121, 55),
                Location = new Point(96, 47),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Black,
                ForeColor = Color.White,
                Font = new Font("Arial", 14, FontStyle.Bold),
                FlatAppearance =
                    {
                        BorderSize = 0,
                        BorderColor = Color.Black
                    }

            };
            Button button2 = new Button
            {
                Text = "공정현황조회",
                Size = new Size(121, 55),
                Location = new Point(223, 47), // 첫 번째 버튼 옆에 위치 설정 (X 좌표를 더 크게 설정)
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Black,
                ForeColor = Color.White,
                Font = new Font("Arial", 14, FontStyle.Bold),
                FlatAppearance =
                {
                    BorderSize = 0,
                    BorderColor = Color.Black
                }
            };
            this.Controls.Add(button);
            this.Controls.Add(button2);
            button.BringToFront();
            button2.BringToFront();
            button.Click += button1_Click;
            button2.Click += button2_Click;
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            //MessageBox.Show("hI1233131", "lnfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            //MessageBox.Show("hI", "lnfo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Form4 form4 = new Form4();
            //form4.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
```
