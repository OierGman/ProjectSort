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
            pictureBox1.Size = new Size(1500, 1000);
            this.Controls.Add(pictureBox1);

            Bitmap graph = new Bitmap(1400, 1000);
            Graphics graphGraphics = Graphics.FromImage(graph);

            int y = 5;
            int x = 900 / unsorted_list.Length;
            foreach (int i in unsorted_list) 
            {
                graphGraphics.FillRectangle(Brushes.Red, y, 450, x, i * 5);
                y += x + 2;
            }

            pictureBox1.Image = graph;
            graph.RotateFlip(RotateFlipType.RotateNoneFlipY);
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

        void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            CreateBitmapAtRuntime();

            for (i = 0; i < n1; i++)
                L[i] = arr[l + i];
            for (j = 0; j < n2; j++)
                R[j] = arr[m + 1 + j];

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                    pictureBox1.Update();
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                    pictureBox1.Update();
                }
                k++;
                pictureBox1.Update();
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
                pictureBox1.Update();
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
                pictureBox1.Update();
            }
            pictureBox1.Update();
        }

        void merge_sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                merge_sort(arr, l, m);
                CreateBitmapAtRuntime();
                pictureBox1.Update();
                merge_sort(arr, m + 1, r);
                pictureBox1.Update();

                merge(arr, l, m, r);
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

            else if (checkBoxMerge.Checked == true)
            {
                merge_sort(unsorted_list, 0, unsorted_list.Length - 1);
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
                checkBoxMerge.Checked = false;
            }
        }

        private void checkBoxInsertion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInsertion.Checked == true)
            {
                checkBoxBubble.Checked = false;
                checkBoxQuickSort.Checked = false;
                checkBoxMerge.Checked = false;
            }
        }

        private void checkBoxMerge_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMerge.Checked == true)
            {
                checkBoxBubble.Checked = false;
                checkBoxQuickSort.Checked = false;
                checkBoxInsertion.Checked = false;
            }
        }
    }
}
