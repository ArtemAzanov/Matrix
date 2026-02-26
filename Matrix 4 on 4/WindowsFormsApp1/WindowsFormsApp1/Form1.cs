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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int Det3x3(int a11, int a12, int a13, int a21, int a22, int a23, int a31, int a32, int a33)
            {
                return a11 * a22 * a33 + a12 * a23 * a31 + a13 * a21 * a32 - a13 * a22 * a31 - a11 * a23 * a32 - a12 * a21 * a33;
            }
            

                    int x1 = Convert.ToInt32(textBox1.Text);
                    int y1 = Convert.ToInt32(textBox2.Text);
                    int z1 = Convert.ToInt32(textBox3.Text);
                    int t1 = Convert.ToInt32(textBox4.Text);
                    int x2 = Convert.ToInt32(textBox5.Text);
                    int y2 = Convert.ToInt32(textBox6.Text);
                    int z2 = Convert.ToInt32(textBox7.Text);
                    int t2 = Convert.ToInt32(textBox8.Text);
                    int x3 = Convert.ToInt32(textBox9.Text);
                    int y3 = Convert.ToInt32(textBox10.Text);
                    int z3 = Convert.ToInt32(textBox11.Text);
                    int t3 = Convert.ToInt32(textBox12.Text);
                    int x4 = Convert.ToInt32(textBox13.Text);
                    int y4 = Convert.ToInt32(textBox14.Text);
                    int z4 = Convert.ToInt32(textBox15.Text);
                    int t4 = Convert.ToInt32(textBox16.Text);
                    int r1 = Convert.ToInt32(textBox17.Text);
                    int r2 = Convert.ToInt32(textBox18.Text);
                    int r3 = Convert.ToInt32(textBox19.Text);
                    int r4 = Convert.ToInt32(textBox20.Text);


            int minor1 = Det3x3(y2, z2, t2, y3, z3, t3, y4, z4, t4);  
            int minor2 = Det3x3(x2, z2, t2, x3, z3, t3, x4, z4, t4);  
            int minor3 = Det3x3(x2, y2, t2, x3, y3, t3, x4, y4, t4);  
            int minor4 = Det3x3(x2, y2, z2, x3, y3, z3, x4, y4, z4); 

            
            double det = x1 * minor1 - y1 * minor2 + z1 * minor3 - t1 * minor4;
           

            
            double detX = r1 * Det3x3(y2, z2, t2, y3, z3, t3, y4, z4, t4)
                        - y1 * Det3x3(r2, z2, t2, r3, z3, t3, r4, z4, t4)
                        + z1 * Det3x3(r2, y2, t2, r3, y3, t3, r4, y4, t4)
                        - t1 * Det3x3(r2, y2, z2, r3, y3, z3, r4, y4, z4);

           
            double detY = x1 * Det3x3(r2, z2, t2, r3, z3, t3, r4, z4, t4)
                        - r1 * Det3x3(x2, z2, t2, x3, z3, t3, x4, z4, t4)
                        + z1 * Det3x3(x2, r2, t2, x3, r3, t3, x4, r4, t4)
                        - t1 * Det3x3(x2, r2, z2, x3, r3, z3, x4, r4, z4);

            
            double detZ = x1 * Det3x3(y2, r2, t2, y3, r3, t3, y4, r4, t4)
                        - y1 * Det3x3(x2, r2, t2, x3, r3, t3, x4, r4, t4)
                        + r1 * Det3x3(x2, y2, t2, x3, y3, t3, x4, y4, t4)
                        - t1 * Det3x3(x2, y2, r2, x3, y3, r3, x4, y4, r4);

            
            double detT = x1 * Det3x3(y2, z2, r2, y3, z3, r3, y4, z4, r4)
                        - y1 * Det3x3(x2, z2, r2, x3, z3, r3, x4, z4, r4)
                        + z1 * Det3x3(x2, y2, r2, x3, y3, r3, x4, y4, r4)
                        - r1 * Det3x3(x2, y2, z2, x3, y3, z3, x4, y4, z4);



            label5.Text = Convert.ToString(detX / det);
            label7.Text = Convert.ToString(detY / det);
            label9.Text = Convert.ToString(detZ / det);
            label11.Text = Convert.ToString(detT / det);




        }
    }
}
