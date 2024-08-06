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
