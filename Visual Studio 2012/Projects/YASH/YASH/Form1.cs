using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YASH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Exit?", "Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = openFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Image File(*.jpg;*.png;*.jpeg;*.gif;*.bmp)|*.jpg;*.png;*.jpeg;*.gif;*.bmp";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog2.FileName);

            }
        }

        private void butsub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Fill First Name Properly");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please Fill Middle Name Properly");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please Fill Last Name Properly");
            }
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please Select Your Branch");
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Please Select Your Semester");
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Please Fill CPI Properly");
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Please Fill SPI Properly");
            } if (textBox7.Text == "")
            {
                MessageBox.Show("Please Fill Contect Properly");
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("Please Fill Address Properly");
            }

        }

        private void btnper_Click(object sender, EventArgs e)
        {
            label14.Text = Convert.ToString((Convert.ToDouble(textBox5.Text) - 0.5) * 10);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox4.TextLength < 12)
            {
                MessageBox.Show("Enter 12 digit Enrollment Number");
            }
        }
    }
}
