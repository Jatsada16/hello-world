namespace GPA_culator
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGPANAME = new System.Windows.Forms.TextBox();
            this.textBoxGPAINPUT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMAXNAME = new System.Windows.Forms.TextBox();
            this.textBoxMINNAME = new System.Windows.Forms.TextBox();
            this.textBoxGPAX = new System.Windows.Forms.TextBox();
            this.textBoxMAXGPA = new System.Windows.Forms.TextBox();
            this.textBoxMINGPA = new System.Windows.Forms.TextBox();
            this.textBoxALLDATA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPA INPUT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxGPANAME
            // 
            this.textBoxGPANAME.Location = new System.Drawing.Point(236, 31);
            this.textBoxGPANAME.Name = "textBoxGPANAME";
            this.textBoxGPANAME.Size = new System.Drawing.Size(369, 52);
            this.textBoxGPANAME.TabIndex = 1;
            // 
            // textBoxGPAINPUT
            // 
            this.textBoxGPAINPUT.Location = new System.Drawing.Point(621, 31);
            this.textBoxGPAINPUT.Name = "textBoxGPAINPUT";
            this.textBoxGPAINPUT.Size = new System.Drawing.Size(171, 52);
            this.textBoxGPAINPUT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "GPAX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "MIN GPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "MAX GPA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(837, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMAXNAME
            // 
            this.textBoxMAXNAME.Location = new System.Drawing.Point(236, 262);
            this.textBoxMAXNAME.Name = "textBoxMAXNAME";
            this.textBoxMAXNAME.Size = new System.Drawing.Size(369, 52);
            this.textBoxMAXNAME.TabIndex = 8;
            // 
            // textBoxMINNAME
            // 
            this.textBoxMINNAME.Location = new System.Drawing.Point(236, 340);
            this.textBoxMINNAME.Name = "textBoxMINNAME";
            this.textBoxMINNAME.Size = new System.Drawing.Size(369, 52);
            this.textBoxMINNAME.TabIndex = 9;
            // 
            // textBoxGPAX
            // 
            this.textBoxGPAX.Location = new System.Drawing.Point(621, 188);
            this.textBoxGPAX.Name = "textBoxGPAX";
            this.textBoxGPAX.Size = new System.Drawing.Size(171, 52);
            this.textBoxGPAX.TabIndex = 10;
            // 
            // textBoxMAXGPA
            // 
            this.textBoxMAXGPA.Location = new System.Drawing.Point(621, 262);
            this.textBoxMAXGPA.Name = "textBoxMAXGPA";
            this.textBoxMAXGPA.Size = new System.Drawing.Size(171, 52);
            this.textBoxMAXGPA.TabIndex = 11;
            // 
            // textBoxMINGPA
            // 
            this.textBoxMINGPA.Location = new System.Drawing.Point(621, 340);
            this.textBoxMINGPA.Name = "textBoxMINGPA";
            this.textBoxMINGPA.Size = new System.Drawing.Size(171, 52);
            this.textBoxMINGPA.TabIndex = 12;
            // 
            // textBoxALLDATA
            // 
            this.textBoxALLDATA.Location = new System.Drawing.Point(51, 398);
            this.textBoxALLDATA.Multiline = true;
            this.textBoxALLDATA.Name = "textBoxALLDATA";
            this.textBoxALLDATA.Size = new System.Drawing.Size(948, 164);
            this.textBoxALLDATA.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 540);
            this.Controls.Add(this.textBoxALLDATA);
            this.Controls.Add(this.textBoxMINGPA);
            this.Controls.Add(this.textBoxMAXGPA);
            this.Controls.Add(this.textBoxGPAX);
            this.Controls.Add(this.textBoxMINNAME);
            this.Controls.Add(this.textBoxMAXNAME);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGPAINPUT);
            this.Controls.Add(this.textBoxGPANAME);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxGPANAME;
        private TextBox textBoxGPAINPUT;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox textBoxMAXNAME;
        private TextBox textBoxMINNAME;
        private TextBox textBoxGPAX;
        private TextBox textBoxMAXGPA;
        private TextBox textBoxMINGPA;
        private TextBox textBoxALLDATA;
    }
}