using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Math
{
    public partial class Form1 : Form
    {
        

        int a;
        int b;
        int c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)//IF button click!
        {
            string A = textBox_A.Text; a = int.Parse(A);
            string B = textBox_B.Text; b = int.Parse(B);
            string C = textBox_C.Text; c = int.Parse(C);




            if (a != 0 && b * b - 4 * a * c >= 1)
            {
                double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

                textBox_x1.Text = x1.ToString();
                textBox_x2.Text = x2.ToString();
            }
            else if (a != 0 && b * b - 4 * a * c == 0)
            {
                double x = -b / 2 * a;
                textBox_x1.Text = x.ToString();
                
            }
            else { MessageBox.Show("Bitte geben Sie den Regeln entsprechende Zahlen ein oder die Gleichung hazt keine Lösung"); }
        }

        private void TH1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string A = textBox_A.Text; a = int.Parse(A);
            string B = textBox_B.Text; b = int.Parse(B);
            string C = textBox_C.Text; c = int.Parse(C);




            if (a != 0 && b * b - 4 * a * c >= 1)
            {
                double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

                textBox_x1.Text = x1.ToString();
                textBox_x2.Text = x2.ToString();
            }
            else if (a != 0 && b * b - 4 * a * c == 0)
            {
                double x = -b / 2 * a;
                textBox_x1.Text = x.ToString();

            }
            else { MessageBox.Show("Bitte geben Sie den Regeln entsprechende Zahlen ein oder die Gleichung hazt keine Lösung"); }
        }
    }
}
