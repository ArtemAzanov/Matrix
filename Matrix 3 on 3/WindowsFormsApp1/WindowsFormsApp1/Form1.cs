using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            int Det3x3(int a11, int a12, int a13, int a21, int a22, int a23, int a31, int a32, int a33)
            {
                return a11 * a22 * a33 + a21 * a13 * a32 + a12 * a23 * a31 - (a13 * a22 * a31 + a23 * a32 * a11 + a21 * a12 * a33);
            }

            int x1 = Convert.ToInt32(textBox1.Text);
            int y1 = Convert.ToInt32(textBox2.Text);
            int z1 = Convert.ToInt32(textBox3.Text);
            int x2 = Convert.ToInt32(textBox4.Text);
            int y2 = Convert.ToInt32(textBox5.Text);
            int z2 = Convert.ToInt32(textBox6.Text);
            int x3 = Convert.ToInt32(textBox7.Text);
            int y3 = Convert.ToInt32(textBox8.Text);
            int z3 = Convert.ToInt32(textBox9.Text);
            int r1 = Convert.ToInt32(textBox10.Text);
            int r2 = Convert.ToInt32(textBox11.Text);
            int r3 = Convert.ToInt32(textBox12.Text);

            int min1 = Det3x3(x1, y1, z1, x2, y2, z2, x3, y3, z3);
            int min2 = Det3x3(r1, y1, z1, r2, y2, z2, r3, y3, z3);
            int min3 = Det3x3(x1, r1, z1, x2, r2, z2, x3, r3, z3);
            int min4 = Det3x3(x1, y1, r1, x2, y2, r2, x3, y3, r3);

            label6.Text = Convert.ToString(min2 / min1);
            label8.Text = Convert.ToString(min3 / min1);
            label10.Text = Convert.ToString(min4 / min1);
        }
    }
}
