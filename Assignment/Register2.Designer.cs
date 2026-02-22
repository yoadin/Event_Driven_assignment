namespace Assignment
{
    partial class RegStep2
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
            txtUni = new TextBox();
            comboBoxDeg = new ComboBox();
            graduationYear = new NumericUpDown();
            txtDep = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Nxbt2 = new Button();
            BckBt1 = new Button();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)graduationYear).BeginInit();
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
            // txtUni
            // 
            txtUni.Location = new Point(220, 108);
            txtUni.Name = "txtUni";
            txtUni.Size = new Size(182, 31);
            txtUni.TabIndex = 2;
            // 
            // comboBoxDeg
            // 
            comboBoxDeg.FormattingEnabled = true;
            comboBoxDeg.Items.AddRange(new object[] { "Diploma", "Asscociate Degree(AA)", "Bachelor's Degree", "Master's Degree", "Doctoral Degree(PHD)" });
            comboBoxDeg.Location = new Point(220, 174);
            comboBoxDeg.Name = "comboBoxDeg";
            comboBoxDeg.Size = new Size(182, 33);
            comboBoxDeg.TabIndex = 3;
            // 
            // graduationYear
            // 
            graduationYear.Location = new Point(220, 246);
            graduationYear.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            graduationYear.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            graduationYear.Name = "graduationYear";
            graduationYear.Size = new Size(180, 31);
            graduationYear.TabIndex = 4;
            graduationYear.Value = new decimal(new int[] { 1950, 0, 0, 0 });
            // 
            // txtDep
            // 
            txtDep.Location = new Point(220, 316);
            txtDep.Name = "txtDep";
            txtDep.Size = new Size(182, 31);
            txtDep.TabIndex = 5;
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
            // Nxbt2
            // 
            Nxbt2.Location = new Point(676, 404);
            Nxbt2.Name = "Nxbt2";
            Nxbt2.Size = new Size(112, 34);
            Nxbt2.TabIndex = 9;
            Nxbt2.Text = "Next";
            Nxbt2.UseVisualStyleBackColor = true;
            Nxbt2.Click += Nxbt2_Click;
            // 
            // BckBt1
            // 
            BckBt1.Location = new Point(52, 404);
            BckBt1.Name = "BckBt1";
            BckBt1.Size = new Size(112, 34);
            BckBt1.TabIndex = 10;
            BckBt1.Text = "Back";
            BckBt1.UseVisualStyleBackColor = true;
            BckBt1.Click += BckBt1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(252, 404);
            progressBar1.Maximum = 3;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(150, 34);
            progressBar1.TabIndex = 11;
            progressBar1.Value = 2;
            // 
            // RegStep2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(BckBt1);
            Controls.Add(Nxbt2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDep);
            Controls.Add(graduationYear);
            Controls.Add(comboBoxDeg);
            Controls.Add(txtUni);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegStep2";
            Text = "RegisterStep2";
            ((System.ComponentModel.ISupportInitialize)graduationYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUni;
        private ComboBox comboBoxDeg;
        private NumericUpDown graduationYear;
        private TextBox txtDep;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Nxbt2;
        private Button BckBt1;
        private ProgressBar progressBar1;
    }
}