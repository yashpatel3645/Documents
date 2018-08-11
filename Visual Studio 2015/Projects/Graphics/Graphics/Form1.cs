using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Graphicsg
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
        {
            base.OnPaint(pe);
            Bitmap img = (Bitmap)Image.FromFile(@"c:\users\king_heart\documents\visual studio 2015\Projects\Graphics\Graphics\img.bmp",true);
            TextureBrush tr = new TextureBrush(img);
            Rectangle r = new Rectangle(20, 20, 200, 100);
            Graphics g = pe.Graphics;
            g.FillRectangle(tr, r);


            

        }

    }
}
