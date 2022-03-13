using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSort
{
    public partial class Form1 : Form
    {
        int p;
        int[] unsorted_list;

        PictureBox pictureBox1 = new PictureBox();
        public void CreateBitmapAtRuntime()
        {
            pictureBox1.Size = new Size(1000, 1000);
            this.Controls.Add(pictureBox1);

            Bitmap graph = new Bitmap(1000, 1000);
            Graphics graphGraphics = Graphics.FromImage(graph);
            int y = 0;
            int x = 300 / unsorted_list.Length;
            foreach (int i in unsorted_list) 
            {
                graphGraphics.FillRectangle(Brushes.Red, y, 35, x, i * 5);
                y += x + 2;
            }
            pictureBox1.Image = graph;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            int temp = 0;

            for (int write = 0; write < unsorted_list.Length; write++)
            {
                for (int sort = 0; sort < unsorted_list.Length - 1; sort++)
                {
                    if (unsorted_list[sort] > unsorted_list[sort + 1])
                    {
                        temp = unsorted_list[sort + 1];
                        unsorted_list[sort + 1] = unsorted_list[sort];
                        unsorted_list[sort] = temp;
                        // Thread.Sleep(250);
                    }
                    CreateBitmapAtRuntime();
                    pictureBox1.Update();
                }
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            bool pValue = Int32.TryParse(textBoxArrayLength.Text, out int tempIntP);

            if (pValue == true)
            {
                p = tempIntP;
            }
            int Min = 1;
            int Max = 70;

            unsorted_list = new int[p];
            Random randNum = new Random();
            for (int i = 0; i < unsorted_list.Length; i++)
            {
                unsorted_list[i] = randNum.Next(Min, Max);
            }
            CreateBitmapAtRuntime();
            pictureBox1.Update();
        }
    }
}
