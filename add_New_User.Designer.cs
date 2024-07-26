namespace WinFormsApp1
{
    partial class add_New_User
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
            panel1 = new Panel();
            button1 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 275);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(112, 230);
            button1.Name = "button1";
            button1.Size = new Size(152, 33);
            button1.TabIndex = 2;
            button1.Text = "Add New User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            textBox6.Location = new Point(112, 199);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(233, 25);
            textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            textBox5.Location = new Point(112, 163);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(233, 25);
            textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            textBox4.Location = new Point(112, 127);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(233, 25);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            textBox3.Location = new Point(112, 92);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 25);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            textBox2.Location = new Point(112, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 25);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            textBox1.Location = new Point(112, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 25);
            textBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(7, 199);
            label6.Name = "label6";
            label6.Size = new Size(60, 19);
            label6.TabIndex = 0;
            label6.Text = "Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(7, 163);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(7, 127);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(7, 95);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 0;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(7, 56);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 0;
            label1.Text = "Fisrt Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(310, 9);
            label7.Name = "label7";
            label7.Size = new Size(161, 21);
            label7.TabIndex = 0;
            label7.Text = "Add New User Form";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(446, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(360, 263);
            dataGridView1.TabIndex = 1;
            // 
            // add_New_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(858, 336);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Name = "add_New_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "add_New_User";
            Load += add_New_User_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button1;
        private Label label7;
        private DataGridView dataGridView1;
    }
}