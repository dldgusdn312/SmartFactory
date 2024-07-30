```
namespace BoxingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 number1 = 0;
            int number2 = 100;

            Double number3 = 3.14;
            double number4 = 31.4159;

            number1 = number2;
            Console.WriteLine(number1);

            number2 = number1;
            Console.WriteLine(number2);

            number3 = number4;
            number4 = number3;

            char ch1 = 'A';
            char ch2 = 'B';
            ch1 = ch2;
            ch2 = ch1;

            float f1 = 3.14F;
            Double f2 = f1;
            f1 = (float)f2;
            
        }
    }
}
```
```
using System.Text;

namespace BoxingApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 42;
            //Int32 boxed = number; //Boxing
            //int unboxed = boxed; //Unboxing

            //object obj = number; //UpCasting, Boxing
            //int downed = (int)obj; //강제형변환, DownCasting
            string str1 = "Hello World";
            string str2 = new string("Hello World");
            string str3 = "Hello World";
            string str4 = "Hello World";
            string str5 = new string("Hello World");

            object obj1 = new object();
            object obj2 = new object();

            StringBuilder sb1 = new StringBuilder("gd");
            StringBuilder sb2 = new StringBuilder("gd");

            Console.WriteLine($"str1 : {str1.GetHashCode()}");
            Console.WriteLine($"str2 : {str2.GetHashCode()}");
            Console.WriteLine($"str3 : {str3.GetHashCode()}");
            Console.WriteLine($"str4 : {str4.GetHashCode()}");
            Console.WriteLine($"str5 : {str5.GetHashCode()}");
            Console.WriteLine();
            Console.WriteLine($"obj1 : {obj1.GetHashCode()}");
            Console.WriteLine($"obj2 : {obj2.GetHashCode()}");
            Console.WriteLine($"sb1 : {sb1.GetHashCode()} {sb1.ToString()}");
            Console.WriteLine($"sb1 : {sb2.GetHashCode()} {sb2.ToString()}");


        }
    }
}
```
```
<깊은복사>
using System;

namespace DeepCopy
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }

            Console.WriteLine("Deep Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }
        }
    }
}
```
```
<P170 연습문제>
<여러 그림 동시에 관리하기>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form2 : Form
    {
        private int Sajin_1 = 1;
        private int Sajin_2 = 1;
        private int Sajin_3 = 1;

        private int Sajin_1_Max = 4;
        private int Sajin_2_Max = 5;
        private int Sajin_3_Max = 7;

        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/재롱피우는 오버액션토끼/" + Sajin_1 + ".jpg");
            pictureBox2.Image = Image.FromFile(System.Environment.CurrentDirectory + "/다가오는 코끼리 두마리/" + Sajin_2 + ".jpg");
            pictureBox3.Image = Image.FromFile(System.Environment.CurrentDirectory + "/돌아서는 신랑신부/" + Sajin_3 + ".jpg");

            Sajin_1++;
            Sajin_2++;
            Sajin_3++;
            if (Sajin_1 > Sajin_1_Max)
                Sajin_1 = 1;
            if (Sajin_2 > Sajin_1_Max)
                Sajin_2 = 1;
            if (Sajin_3 > Sajin_1_Max)
                Sajin_3 = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = hScrollBar1.Value;
        }
    }
}
```
```
<P173 연습문제>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form4 : Form
    {
        private int Sajin_1 = 1;
        private int Sajin_2 = 1;
        private int Sajin_3 = 1;

        private int Sajin_1_Max = 4;
        private int Sajin_2_Max = 5;
        private int Sajin_3_Max = 7;
        public Form4()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Environment.CurrentDirectory + "/재롱피우는 오버액션토끼/" + Sajin_1 + ".jpg");
            Sajin_1++;
            if (Sajin_1 > Sajin_1_Max)
                Sajin_1 = 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(System.Environment.CurrentDirectory + "/다가오는 코끼리 두마리/" + Sajin_2 + ".jpg");
            Sajin_2++;
            if (Sajin_2 > Sajin_1_Max)
                Sajin_2 = 1;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(System.Environment.CurrentDirectory + "/돌아서는 신랑신부/" + Sajin_3 + ".jpg");
            Sajin_3++;
            if (Sajin_3 > Sajin_1_Max)
                Sajin_3 = 1;
        }

        private void 종료ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void 빠르게ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10; timer2.Interval = 10; timer3.Interval = 10;
        }

        private void 중간ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500; timer2.Interval = 500; timer3.Interval = 500;
        }

        private void 느리게ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000; timer2.Interval = 1000; timer3.Interval = 1000;
        }

        private void 빠르게ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
        }

        private void 중간ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }

        private void 느리게ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void 빠르게ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer2.Interval = 10;
        }

        private void 중간ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer2.Interval = 500;
        }

        private void 느리게ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
        }

        private void 빠르게ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            timer3.Interval = 10;
        }

        private void 중간ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            timer3.Interval = 500;
        }

        private void 느리게ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            timer3.Interval = 1000;
        }

        private void 느리게ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true && timer2.Enabled == true && timer3.Enabled == true)
            {
                timer1.Enabled = false; timer2.Enabled = false; timer3.Enabled = false;
                느리게ToolStripMenuItem.Text = "전체 동작";
            }
            else if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false)
            {
                timer1.Enabled = true; timer2.Enabled = true; timer3.Enabled = true;
                느리게ToolStripMenuItem.Text = "전체 동작";
            }
        }

        private void 개발환경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("운영 체제 : Windows10\n개발 도구 : Microsoft Visual Studio Community 2022" + "\n개발 언어 : C#", "[개발 환경]");
        }
    }
}
```
