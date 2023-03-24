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
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDiaog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;

        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            openFileDiaog1 = new OpenFileDialog();
            if(openFileDiaog1.ShowDialog() == DialogResult.OK) 
            {
                richTextBox1.LoadFile(openFileDiaog1.FileName,RichTextBoxStreamType.RichText);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.RichText);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e, FontDialog fontDialog)
        {
            fontDialog1 = new FontDialog();
            if(fontDialog1.ShowDialog() == DialogResult.OK) 
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if(colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;   
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void mởFormGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            add.ShowDialog();

        }

        private void mởFormSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 add = new Form3();
            add.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bàiTậpKhácToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
