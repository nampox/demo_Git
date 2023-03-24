﻿using System;
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
    public partial class Form3 : Form
    {
        List<ListViewItem> list;
        public Form3()
        {
            InitializeComponent();
            list = new List<ListViewItem>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode noo = new TreeNode();
            noo.Text = txtKhoa.Text;

            treeView1.Nodes.Add(noo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode noo = new TreeNode();
            noo.Text = txtLop.Text;

            treeView1.SelectedNode.Nodes.Add(noo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dtl = MessageBox.Show("Thông Báo !","Bạn có chắc chắn muốn xóa?",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (dtl == DialogResult.Yes)
            {
                treeView1.SelectedNode.Remove();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.Items.Add(txtMa.Text);
            item.SubItems.Add(txtTen.Text);
            item.SubItems.Add(dateTimePicker1.Value.ToString());
            item.SubItems.Add(treeView1.SelectedNode.Text);

            list.Add(item);

        }

        private void button5_Click(object sender, EventArgs e)
        {
           if(listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtMa.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtTen.Text;
                listView1.SelectedItems[0].SubItems[2].Text = dateTimePicker1.Value.ToShortDateString();
                listView1.SelectedItems[0].SubItems[3].Text = treeView1.SelectedNode.Text;
            }    
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count > 0) 
            {
                txtMa.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtTen.Text = listView1.SelectedItems[0].SubItems[1].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[2].Text; 

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Chọn một đối tượng.!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string a = "";
            a = treeView1.SelectedNode.Text;
            for(int i=0;i<list.Count;i++) 
            {
                if(a == list[i].SubItems[3].Text)
                {
                    listView1.Items.Clear();
                    ListViewItem item = listView1.Items.Add(list[i].SubItems[0].Text);
                    item.SubItems.Add(list[i].SubItems[1].Text);
                    item.SubItems.Add(list[i].SubItems[2].Text);
                    item.SubItems.Add(list[i].SubItems[3].Text);
                }    
            }
        }
    }
}
