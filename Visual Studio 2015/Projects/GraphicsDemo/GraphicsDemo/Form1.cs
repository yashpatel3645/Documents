using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsDemo
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
    
        protected override void OnPaint(PaintEventArgs pe)
            
        {try
            {
                Bitmap myimg = (Bitmap)Image.FromFile(@"c:\users\king_heart\documents\visual studio 2015\Projects\GraphicsDemo\GraphicsDemo\img.bmp", true);
                TextureBrush t = new TextureBrush(myimg);
                base.OnPaint(pe);
                Pen p = new Pen(t);

                Graphics g = pe.Graphics;
                g.DrawRectangle(p, 20, 20, 200, 100);
            }
            catch(Exception ae) { MessageBox.Show(ae.ToString()); }
        }
    }
}
