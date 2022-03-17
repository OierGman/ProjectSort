
namespace ProjectSort
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArrayLength = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.checkBoxBubble = new System.Windows.Forms.CheckBox();
            this.checkBoxQuickSort = new System.Windows.Forms.CheckBox();
            this.checkBoxInsertion = new System.Windows.Forms.CheckBox();
            this.checkBoxMerge = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonSort
            // 
            this.buttonSort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSort.Location = new System.Drawing.Point(0, 578);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(1127, 50);
            this.buttonSort.TabIndex = 0;
            this.buttonSort.Text = "Sort Graph";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select The Length of Your List";
            // 
            // textBoxArrayLength
            // 
            this.textBoxArrayLength.Location = new System.Drawing.Point(164, 4);
            this.textBoxArrayLength.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxArrayLength.Name = "textBoxArrayLength";
            this.textBoxArrayLength.Size = new System.Drawing.Size(76, 20);
            this.textBoxArrayLength.TabIndex = 3;
            this.textBoxArrayLength.TextChanged += new System.EventHandler(this.textBoxArrayLength_TextChanged);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(243, 5);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(56, 19);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // checkBoxBubble
            // 
            this.checkBoxBubble.AutoSize = true;
            this.checkBoxBubble.Location = new System.Drawing.Point(412, 6);
            this.checkBoxBubble.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBubble.Name = "checkBoxBubble";
            this.checkBoxBubble.Size = new System.Drawing.Size(81, 17);
            this.checkBoxBubble.TabIndex = 5;
            this.checkBoxBubble.Text = "Bubble Sort";
            this.checkBoxBubble.UseVisualStyleBackColor = true;
            this.checkBoxBubble.CheckedChanged += new System.EventHandler(this.checkBoxBubble_CheckedChanged);
            // 
            // checkBoxQuickSort
            // 
            this.checkBoxQuickSort.AutoSize = true;
            this.checkBoxQuickSort.Location = new System.Drawing.Point(528, 6);
            this.checkBoxQuickSort.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxQuickSort.Name = "checkBoxQuickSort";
            this.checkBoxQuickSort.Size = new System.Drawing.Size(76, 17);
            this.checkBoxQuickSort.TabIndex = 6;
            this.checkBoxQuickSort.Text = "Quick Sort";
            this.checkBoxQuickSort.UseVisualStyleBackColor = true;
            this.checkBoxQuickSort.CheckedChanged += new System.EventHandler(this.checkBoxQuickSort_CheckedChanged);
            // 
            // checkBoxInsertion
            // 
            this.checkBoxInsertion.AutoSize = true;
            this.checkBoxInsertion.Location = new System.Drawing.Point(637, 6);
            this.checkBoxInsertion.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxInsertion.Name = "checkBoxInsertion";
            this.checkBoxInsertion.Size = new System.Drawing.Size(88, 17);
            this.checkBoxInsertion.TabIndex = 7;
            this.checkBoxInsertion.Text = "Insertion Sort";
            this.checkBoxInsertion.UseVisualStyleBackColor = true;
            this.checkBoxInsertion.CheckedChanged += new System.EventHandler(this.checkBoxInsertion_CheckedChanged);
            // 
            // checkBoxMerge
            // 
            this.checkBoxMerge.AutoSize = true;
            this.checkBoxMerge.Location = new System.Drawing.Point(754, 6);
            this.checkBoxMerge.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxMerge.Name = "checkBoxMerge";
            this.checkBoxMerge.Size = new System.Drawing.Size(78, 17);
            this.checkBoxMerge.TabIndex = 8;
            this.checkBoxMerge.Text = "Merge Sort";
            this.checkBoxMerge.UseVisualStyleBackColor = true;
            this.checkBoxMerge.CheckedChanged += new System.EventHandler(this.checkBoxMerge_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 628);
            this.Controls.Add(this.checkBoxMerge);
            this.Controls.Add(this.checkBoxInsertion);
            this.Controls.Add(this.checkBoxQuickSort);
            this.Controls.Add(this.checkBoxBubble);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.textBoxArrayLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSort);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArrayLength;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.CheckBox checkBoxBubble;
        private System.Windows.Forms.CheckBox checkBoxQuickSort;
        private System.Windows.Forms.CheckBox checkBoxInsertion;
        private System.Windows.Forms.CheckBox checkBoxMerge;
    }
}

