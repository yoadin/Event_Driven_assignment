namespace Assignment
{
    partial class Register2
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 0;
            label1.Text = "Education History";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 322);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Department";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 31);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Diploma", "Asscociate Degree(AA)", "Bachelor's Degree", "Master's Degree", "Doctoral Degree(PHD)" });
            comboBox1.Location = new Point(220, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(220, 246);
            numericUpDown1.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1950, 0, 0, 0 });
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 316);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 31);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 114);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 6;
            label3.Text = "University";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 252);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 7;
            label4.Text = "Graduation Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 177);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 8;
            label5.Text = "Degree";
            // 
            // button1
            // 
            button1.Location = new Point(676, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(52, 404);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // Register2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register2";
            Text = "RegisterStep2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}