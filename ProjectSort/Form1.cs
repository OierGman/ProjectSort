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
            pictureBox1.Size = new Size(1500, 1100);
            this.Controls.Add(pictureBox1);

            Bitmap graph = new Bitmap(1400, 1000);
            Graphics graphGraphics = Graphics.FromImage(graph);

            int y = 0;
            int x = 900 / unsorted_list.Length;
            foreach (int i in unsorted_list) 
            {
                graphGraphics.FillRectangle(Brushes.Red, y, 35, x, i * 5);
                y += x + 2;
            }
            pictureBox1.Image = graph;
        }

        private void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                CreateBitmapAtRuntime();
                i = Partition(arr, start, end);
                pictureBox1.Update();

                QuickSort(arr, start, i - 1);
                //Thread.Sleep(50);
                pictureBox1.Update();
                QuickSort(arr, i + 1, end);
                //Thread.Sleep(50);
                pictureBox1.Update();
            }
        }

        private int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                CreateBitmapAtRuntime();
                pictureBox1.Update();
                //Thread.Sleep(50);
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            pictureBox1.Update();
            return i + 1;
        }

        private void insertion_sort(int[] arr)
        {
            int n = arr.Length;
            

            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    CreateBitmapAtRuntime();
                    pictureBox1.Update();
                }
                arr[j + 1] = key;
                pictureBox1.Update();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (checkBoxBubble.Checked == true)
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
                            // Thread.Sleep(500);
                        }
                        CreateBitmapAtRuntime();
                        pictureBox1.Update();
                    }
                }
                MessageBox.Show("Sort Complete");
            }

            else if (checkBoxQuickSort.Checked == true)
            {
                QuickSort(unsorted_list, 0, unsorted_list.Length - 1);
                MessageBox.Show("Sort Complete");
            }

            else if (checkBoxInsertion.Checked == true)
            {
                insertion_sort(unsorted_list);
                MessageBox.Show("Sort Complete");
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            bool pValue = Int32.TryParse(textBoxArrayLength.Text, out int tempIntP);

            if (pValue == true)
            {
                p = tempIntP;
            }   

            if (p > 100)
            {
                MessageBox.Show("Max List Size 100");
                p = 100;
            }

            int Min = 1;
            int Max = 100;

            unsorted_list = new int[p];
            Random randNum = new Random();
            for (int i = 0; i < unsorted_list.Length; i++)
            {
                unsorted_list[i] = randNum.Next(Min, Max);
            }
            CreateBitmapAtRuntime();
            pictureBox1.Update();
        }

        private void checkBoxBubble_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBubble.Checked == true)
            {
                checkBoxQuickSort.Checked = false;
                checkBoxInsertion.Checked = false;
            }
        }

        private void checkBoxQuickSort_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQuickSort.Checked == true)
            {
                checkBoxBubble.Checked = false;
                checkBoxInsertion.Checked = false;
            }
        }

        private void checkBoxInsertion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInsertion.Checked == true)
            {
                checkBoxBubble.Checked = false;
                checkBoxQuickSort.Checked = false;
            }
        }
    }
}
