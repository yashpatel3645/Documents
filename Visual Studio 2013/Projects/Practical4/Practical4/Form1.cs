using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical4
{
    public partial class Form1 : Form
    {
        int size = 10;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnup_Click(object sender, EventArgs e)
        {
            size++;
            if (size < 48)
            {
                richTextBox1.Font = new Font("Times New Roman", size, FontStyle.Regular);
            }
            else
            {
                MessageBox.Show("Maximum size");
            }

        }

        private void btndown_Click(object sender, EventArgs e)
        {
            size--;
            if (size > 8)
            {
                richTextBox1.Font = new Font("Times New Roman", size, FontStyle.Regular);
            }
            else
            {
                MessageBox.Show("Minimum size");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Times New Roman", size, FontStyle.Bold);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Times New Roman", size, FontStyle.Italic);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Times New Roman", size, FontStyle.Underline);
        }
    }
}
