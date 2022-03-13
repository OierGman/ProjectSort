
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
            this.SuspendLayout();
            // 
            // buttonSort
            // 
            this.buttonSort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSort.Location = new System.Drawing.Point(0, 712);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(1503, 61);
            this.buttonSort.TabIndex = 0;
            this.buttonSort.Text = "Sort Graph";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select The Length of Your List";
            // 
            // textBoxArrayLength
            // 
            this.textBoxArrayLength.Location = new System.Drawing.Point(218, 5);
            this.textBoxArrayLength.Name = "textBoxArrayLength";
            this.textBoxArrayLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxArrayLength.TabIndex = 3;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(324, 6);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // checkBoxBubble
            // 
            this.checkBoxBubble.AutoSize = true;
            this.checkBoxBubble.Location = new System.Drawing.Point(550, 8);
            this.checkBoxBubble.Name = "checkBoxBubble";
            this.checkBoxBubble.Size = new System.Drawing.Size(104, 21);
            this.checkBoxBubble.TabIndex = 5;
            this.checkBoxBubble.Text = "Bubble Sort";
            this.checkBoxBubble.UseVisualStyleBackColor = true;
            this.checkBoxBubble.CheckedChanged += new System.EventHandler(this.checkBoxBubble_CheckedChanged);
            // 
            // checkBoxQuickSort
            // 
            this.checkBoxQuickSort.AutoSize = true;
            this.checkBoxQuickSort.Location = new System.Drawing.Point(704, 8);
            this.checkBoxQuickSort.Name = "checkBoxQuickSort";
            this.checkBoxQuickSort.Size = new System.Drawing.Size(96, 21);
            this.checkBoxQuickSort.TabIndex = 6;
            this.checkBoxQuickSort.Text = "Quick Sort";
            this.checkBoxQuickSort.UseVisualStyleBackColor = true;
            this.checkBoxQuickSort.CheckedChanged += new System.EventHandler(this.checkBoxQuickSort_CheckedChanged);
            // 
            // checkBoxInsertion
            // 
            this.checkBoxInsertion.AutoSize = true;
            this.checkBoxInsertion.Location = new System.Drawing.Point(843, 7);
            this.checkBoxInsertion.Name = "checkBoxInsertion";
            this.checkBoxInsertion.Size = new System.Drawing.Size(114, 21);
            this.checkBoxInsertion.TabIndex = 7;
            this.checkBoxInsertion.Text = "Insertion Sort";
            this.checkBoxInsertion.UseVisualStyleBackColor = true;
            this.checkBoxInsertion.CheckedChanged += new System.EventHandler(this.checkBoxInsertion_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 773);
            this.Controls.Add(this.checkBoxInsertion);
            this.Controls.Add(this.checkBoxQuickSort);
            this.Controls.Add(this.checkBoxBubble);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.textBoxArrayLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSort);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

