using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            //how to change type in C# .parse
            //C#에서 자료형 변환하는 법
            
            a *= 2;
            // *= 축약 연산자

            label1.Text = a.ToString();
            //int type to string type .ToString
            //숫자형을 문자열로 바꿀때 .ToString

        }
    }
}
