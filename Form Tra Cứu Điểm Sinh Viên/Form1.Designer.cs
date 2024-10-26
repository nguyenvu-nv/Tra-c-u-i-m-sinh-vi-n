namespace Form_Tra_Cứu_Điểm_Sinh_Viên
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
            this.txt_tracuu = new System.Windows.Forms.TextBox();
            this.btn_tracuu = new System.Windows.Forms.Button();
            this.txt_diem = new System.Windows.Forms.TextBox();
            this.lb_diem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_tracuu
            // 
            this.txt_tracuu.Location = new System.Drawing.Point(249, 71);
            this.txt_tracuu.Name = "txt_tracuu";
            this.txt_tracuu.Size = new System.Drawing.Size(288, 20);
            this.txt_tracuu.TabIndex = 0;
            // 
            // btn_tracuu
            // 
            this.btn_tracuu.Location = new System.Drawing.Point(341, 116);
            this.btn_tracuu.Name = "btn_tracuu";
            this.btn_tracuu.Size = new System.Drawing.Size(75, 23);
            this.btn_tracuu.TabIndex = 1;
            this.btn_tracuu.Text = "Tra cứu";
            this.btn_tracuu.UseVisualStyleBackColor = true;
            this.btn_tracuu.Click += new System.EventHandler(this.btn_tracuu_Click);
            // 
            // txt_diem
            // 
            this.txt_diem.Location = new System.Drawing.Point(333, 213);
            this.txt_diem.Name = "txt_diem";
            this.txt_diem.Size = new System.Drawing.Size(100, 20);
            this.txt_diem.TabIndex = 2;
            // 
            // lb_diem
            // 
            this.lb_diem.AutoSize = true;
            this.lb_diem.Location = new System.Drawing.Point(367, 197);
            this.lb_diem.Name = "lb_diem";
            this.lb_diem.Size = new System.Drawing.Size(31, 13);
            this.lb_diem.TabIndex = 3;
            this.lb_diem.Text = "Điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập mã sinh viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_diem);
            this.Controls.Add(this.txt_diem);
            this.Controls.Add(this.btn_tracuu);
            this.Controls.Add(this.txt_tracuu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tracuu;
        private System.Windows.Forms.Button btn_tracuu;
        private System.Windows.Forms.TextBox txt_diem;
        private System.Windows.Forms.Label lb_diem;
        private System.Windows.Forms.Label label1;
    }
}

