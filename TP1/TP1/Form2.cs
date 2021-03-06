using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://shopee.co.id/");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string items in comboBox1)
            {
                if(items == "Elektronik")
                {
                    Form3 fm = new Form3();
                    fm.Show();
                }
                else if(items == "Makanan")
                {

                }else if(items == "Baju")
                {

                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string items in comboBox2)
            {
                if (items == "100rb - 200rb")
                {

                }
                else if (items == "200rb - 500rb")
                {

                }
                else if (items == "500rb - 1jt")
                {

                }
            }
        }
    }
}
