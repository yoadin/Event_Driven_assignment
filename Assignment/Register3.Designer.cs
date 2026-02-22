namespace Assignment
{
    partial class RegStep3
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
            FinBt = new Button();
            backBt = new Button();
            label2 = new Label();
            txtCountry = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCity = new TextBox();
            txtSubCity = new TextBox();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 0;
            label1.Text = "Current Location";
            // 
            // FinBt
            // 
            FinBt.Location = new Point(676, 404);
            FinBt.Name = "FinBt";
            FinBt.Size = new Size(112, 34);
            FinBt.TabIndex = 1;
            FinBt.Text = "Finish";
            FinBt.UseVisualStyleBackColor = true;
            FinBt.Click += FinBt_Click;
            // 
            // backBt
            // 
            backBt.Location = new Point(22, 404);
            backBt.Name = "backBt";
            backBt.Size = new Size(112, 34);
            backBt.TabIndex = 2;
            backBt.Text = "Back";
            backBt.UseVisualStyleBackColor = true;
            backBt.Click += backBt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(22, 70);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 3;
            label2.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(192, 70);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(150, 31);
            txtCountry.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(22, 143);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 5;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(22, 210);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 6;
            label4.Text = "Sub-City/Kebele";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(192, 137);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 31);
            txtCity.TabIndex = 7;
            // 
            // txtSubCity
            // 
            txtSubCity.Location = new Point(192, 210);
            txtSubCity.Name = "txtSubCity";
            txtSubCity.Size = new Size(150, 31);
            txtSubCity.TabIndex = 8;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(250, 404);
            progressBar1.Maximum = 3;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(150, 34);
            progressBar1.TabIndex = 9;
            progressBar1.Value = 3;
            // 
            // RegStep3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(txtSubCity);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCountry);
            Controls.Add(label2);
            Controls.Add(backBt);
            Controls.Add(FinBt);
            Controls.Add(label1);
            Name = "RegStep3";
            Text = "RegisterStep3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button FinBt;
        private Button backBt;
        private Label label2;
        private TextBox txtCountry;
        private Label label3;
        private Label label4;
        private TextBox txtCity;
        private TextBox txtSubCity;
        private ProgressBar progressBar1;
    }
}