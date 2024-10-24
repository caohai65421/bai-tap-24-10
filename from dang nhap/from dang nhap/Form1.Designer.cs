namespace from_dang_nhap
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(278, 49);
            label1.Name = "label1";
            label1.Size = new Size(310, 54);
            label1.TabIndex = 0;
            label1.Text = "form đăng nhập";
            label1.Click += label1_Click;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(210, 155);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(479, 27);
            textUsername.TabIndex = 1;
            textUsername.TextChanged += textBox1_TextChanged;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(210, 242);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(479, 27);
            textPassword.TabIndex = 2;
            textPassword.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(147, 312);
            button1.Name = "button1";
            button1.Size = new Size(115, 59);
            button1.TabIndex = 3;
            button1.Text = "đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(552, 312);
            button2.Name = "button2";
            button2.Size = new Size(125, 59);
            button2.TabIndex = 4;
            button2.Text = "password";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(78, 151);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 5;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(78, 241);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button button1;
        private BindingSource bindingSource1;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}
