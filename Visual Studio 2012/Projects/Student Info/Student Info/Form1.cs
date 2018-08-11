using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eno.TextLength < 12)
            {
                MessageBox.Show("Enter 12 digit Enrollment Number");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Exit?", "Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (fname.Text == "")
            {
                MessageBox.Show("Please Fill First Name Properly");
            }
            if (mname.Text == "")
            {
                MessageBox.Show("Please Fill Middle Name Properly");
            }
            if (lname.Text == "")
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
            if (cpi.Text == "")
            {
                MessageBox.Show("Please Fill CPI Properly");
            }
            if (spi.Text == "")
            {
                MessageBox.Show("Please Fill SPI Properly");
            } if (con.Text == "")
            {
                MessageBox.Show("Please Fill Contect Properly");
            }
            if (add.Text == "")
            {
                MessageBox.Show("Please Fill Address Properly");
            }

            FileStream F = new FileStream("ndcj.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter s = new StreamWriter(F);
            String detail = fname.Text + " " + mname.Text + " " + lname.Text + " " + eno.Text + " " + comboBox1.SelectedItem.ToString()
                + " " + comboBox2.SelectedItem.ToString() + " " + cpi.Text + " " + spi.Text + " "+label12.Text+" "+ con.Text + " " + add.Text;
            s.Write(detail);
            s.Close();
            F.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label12.Text = Convert.ToString((Convert.ToDouble(cpi.Text) - 0.5) * 10); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
