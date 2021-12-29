using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string uc = textBox2.Text;
            if(uc.Length==8)
            {
                Class1 a = new Class1();
                textBox3.Text = a.encrypt(textBox1.Text, textBox2.Text);
              
            
            }
            else
            {
                MessageBox.Show("8 HANELİ ŞİFRE GİRİNİZ");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class3 b= new Class3();
            textBox4.Text = b.decrypt(textBox3.Text,textBox2.Text,textBox1.Text);

        }
    }
}
