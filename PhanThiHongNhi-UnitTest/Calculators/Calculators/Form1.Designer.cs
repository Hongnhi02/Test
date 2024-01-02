namespace Calculators
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TOÁN CƠ BẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKetQua);
            this.groupBox1.Controls.Add(this.txtSo2);
            this.groupBox1.Controls.Add(this.txtSo1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính toán cơ bản";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(120, 114);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(230, 26);
            this.txtKetQua.TabIndex = 5;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(120, 76);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(230, 26);
            this.txtSo2.TabIndex = 4;
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(120, 34);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(230, 26);
            this.txtSo1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(16, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kết quả";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số thứ hai";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số thứ nhất";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCong
            // 
            this.btnCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCong.Location = new System.Drawing.Point(77, 266);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 33);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTru.Location = new System.Drawing.Point(158, 266);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 33);
            this.btnTru.TabIndex = 3;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            this.btnNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNhan.Location = new System.Drawing.Point(239, 266);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 33);
            this.btnNhan.TabIndex = 4;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            this.btnChia.ForeColor = System.Drawing.Color.Gray;
            this.btnChia.Location = new System.Drawing.Point(320, 266);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 33);
            this.btnChia.TabIndex = 5;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 324);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
    }
}

