namespace quan_ly_sinh_vien_24__10
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            students = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textid = new TextBox();
            textname = new TextBox();
            textclass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)students).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(49, 457);
            button1.Name = "button1";
            button1.Size = new Size(109, 59);
            button1.TabIndex = 0;
            button1.Text = "thêm ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(369, 459);
            button2.Name = "button2";
            button2.Size = new Size(92, 57);
            button2.TabIndex = 1;
            button2.Text = "sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(674, 459);
            button3.Name = "button3";
            button3.Size = new Size(81, 55);
            button3.TabIndex = 2;
            button3.Text = "xoá";
            button3.UseVisualStyleBackColor = true;
            // 
            // students
            // 
            students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            students.Location = new Point(2, 12);
            students.Name = "students";
            students.RowHeadersWidth = 51;
            students.Size = new Size(898, 215);
            students.TabIndex = 3;
            students.CellContentClick += students_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(70, 274);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 4;
            label1.Text = "mã sv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(69, 335);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 5;
            label2.Text = "tên sv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(70, 392);
            label3.Name = "label3";
            label3.Size = new Size(78, 28);
            label3.TabIndex = 6;
            label3.Text = "lớp học";
            label3.Click += label3_Click;
            // 
            // textid
            // 
            textid.Location = new Point(213, 278);
            textid.Name = "textid";
            textid.Size = new Size(542, 27);
            textid.TabIndex = 7;
            // 
            // textname
            // 
            textname.Location = new Point(213, 339);
            textname.Name = "textname";
            textname.Size = new Size(542, 27);
            textname.TabIndex = 8;
            // 
            // textclass
            // 
            textclass.Location = new Point(213, 396);
            textclass.Name = "textclass";
            textclass.Size = new Size(542, 27);
            textclass.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 528);
            Controls.Add(textclass);
            Controls.Add(textname);
            Controls.Add(textid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(students);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView students;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textid;
        private TextBox textname;
        private TextBox textclass;
    }
}
