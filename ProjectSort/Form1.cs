using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSort
{
    public partial class Form1 : Form
    {
        PictureBox pictureBox1 = new PictureBox();
        public void CreateBitmapAtRuntime()
        {
            pictureBox1.Size = new Size(410, 210);
            this.Controls.Add(pictureBox1);

            Bitmap flag = new Bitmap(400, 200);
            Graphics flagGraphics = Graphics.FromImage(flag);
            int red = 0;
            int white = 11;
            while (white <= 100) {
            flagGraphics.FillRectangle(Brushes.Red, 0, red, 400,10);
            flagGraphics.FillRectangle(Brushes.White, 0, white, 400, 10);
            red += 20;
            white += 20;
            }
            pictureBox1.Image = flag;
        }
        public Form1()
        {
            InitializeComponent();
            CreateBitmapAtRuntime();
        }
    }
}
