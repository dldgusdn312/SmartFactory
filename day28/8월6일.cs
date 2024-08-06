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
