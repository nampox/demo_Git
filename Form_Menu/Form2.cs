using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Menu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item ="";
            item = item + txtten.Text;
            if(rbtnam.Checked == true) 
            {
                item = item + ", Nam , ";
            }
            else
            {
                item = item + " , Nữ , ";
            }
            item = item +txtnamsinh.Text;
            item = item + "," + comboBox1.SelectedItem;
            listBox1.Items.Add(item);   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtten.Text = "";
            txtnamsinh.Text = "";
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItems);
        }
    }
}
