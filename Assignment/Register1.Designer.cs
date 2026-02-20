namespace Assignment
{
    partial class Register1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(235, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(235, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(235, 238);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 29);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(367, 238);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 29);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(235, 284);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 68);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 6;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 125);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 7;
            label2.Text = "Fatehr Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 187);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 8;
            label3.Text = "Grandfather Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 238);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 9;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 284);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 10;
            label5.Text = "Birthdate";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(676, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 9);
            label6.Name = "label6";
            label6.Size = new Size(270, 32);
            label6.TabIndex = 12;
            label6.Text = "Personal Information";
            // 
            // Resgister1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Resgister1";
            Text = "RegisterStep1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
    }
}
