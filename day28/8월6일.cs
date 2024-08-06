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
