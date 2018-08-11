using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Way
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width += 2;
                if (rectangleShape2.Width >= 655)
                {
                    timer1.Stop();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }
    }
}
