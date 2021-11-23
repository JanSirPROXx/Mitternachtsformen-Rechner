
namespace _7_Math
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_B = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_x1 = new System.Windows.Forms.TextBox();
            this.textBox_x2 = new System.Windows.Forms.TextBox();
            this.TH1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(19, 22);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(29, 17);
            this.label_B.TabIndex = 1;
            this.label_B.Text = "A =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "B =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "C =";
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(54, 19);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(100, 22);
            this.textBox_A.TabIndex = 4;
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(54, 56);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(100, 22);
            this.textBox_B.TabIndex = 5;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(54, 98);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 22);
            this.textBox_C.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Rechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "X1 = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "X2 = ";
            // 
            // textBox_x1
            // 
            this.textBox_x1.Location = new System.Drawing.Point(54, 194);
            this.textBox_x1.Name = "textBox_x1";
            this.textBox_x1.Size = new System.Drawing.Size(100, 22);
            this.textBox_x1.TabIndex = 10;
            // 
            // textBox_x2
            // 
            this.textBox_x2.Location = new System.Drawing.Point(54, 226);
            this.textBox_x2.Name = "textBox_x2";
            this.textBox_x2.Size = new System.Drawing.Size(100, 22);
            this.textBox_x2.TabIndex = 11;
            // 
            // TH1
            // 
            this.TH1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TH1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 259);
            this.Controls.Add(this.textBox_x2);
            this.Controls.Add(this.textBox_x1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_B);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Mitternachtsformel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_x1;
        private System.Windows.Forms.TextBox textBox_x2;
        private System.ComponentModel.BackgroundWorker TH1;
    }
}

