namespace temp_calculator
{
    partial class form1
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
            this.textBoxC = new System.Windows.Forms.Button();
            this.textBoxF = new System.Windows.Forms.Button();
            this.labal1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxC
            // 
            this.textBoxC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxC.Location = new System.Drawing.Point(245, 71);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(94, 29);
            this.textBoxC.TabIndex = 0;
            this.textBoxC.Text = "convert";
            this.textBoxC.UseVisualStyleBackColor = false;
            this.textBoxC.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(245, 128);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(94, 29);
            this.textBoxF.TabIndex = 1;
            this.textBoxF.Text = "convert";
            this.textBoxF.UseVisualStyleBackColor = true;
            this.textBoxF.Click += new System.EventHandler(this.textBoxF_Click);
            // 
            // labal1
            // 
            this.labal1.AutoSize = true;
            this.labal1.Location = new System.Drawing.Point(189, 76);
            this.labal1.Name = "labal1";
            this.labal1.Size = new System.Drawing.Size(18, 20);
            this.labal1.TabIndex = 2;
            this.labal1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "F";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(58, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labal1);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button textBoxC;
        private Button textBoxF;
        private Label labal1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}