using HttpForm.ViewModels;

namespace HttpForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button5 = new Button();
            button6 = new Button();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(362, 221);
            dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(12, 292);
            button2.Name = "button2";
            button2.Size = new Size(74, 23);
            button2.TabIndex = 3;
            button2.Text = "PostUser";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(92, 292);
            button3.Name = "button3";
            button3.Size = new Size(74, 23);
            button3.TabIndex = 5;
            button3.Text = "DeleteUser";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 10;
            label1.Text = "User";
            // 
            // button5
            // 
            button5.Location = new Point(439, 292);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "PostRank";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(520, 292);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 13;
            button6.Text = "DeleteRank";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(439, 65);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(362, 221);
            dataGridView2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 47);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 15;
            label2.Text = "SpecialistRank";
            // 
            // button1
            // 
            button1.Location = new Point(439, 333);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 16;
            button1.Text = "SearchRank To User ID";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 368);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView2;
        private Label label2;
        private Button button1;
    }
}
