namespace CSharp_Hinhtron1
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
            this.btndientich = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblbankinh = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.btbthoat = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.rdbdientich = new System.Windows.Forms.RadioButton();
            this.rdbchuvi = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbdientich = new System.Windows.Forms.CheckBox();
            this.cbchuvi = new System.Windows.Forms.CheckBox();
            this.btnloai1 = new System.Windows.Forms.Button();
            this.btnloai2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndientich
            // 
            this.btndientich.Location = new System.Drawing.Point(121, 260);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(72, 23);
            this.btndientich.TabIndex = 1;
            this.btndientich.Text = "DIỆN TÍCH";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.btndientich_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ỨNG DỤNG TÍNH DIỆN TÍCH VÀ CHU VI HÌNH TRÒN";
            // 
            // txtbankinh
            // 
            this.txtbankinh.Location = new System.Drawing.Point(196, 133);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(100, 20);
            this.txtbankinh.TabIndex = 3;
            this.txtbankinh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbchuvi);
            this.groupBox1.Controls.Add(this.rdbdientich);
            this.groupBox1.Location = new System.Drawing.Point(459, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Chức Năng";
            // 
            // lblbankinh
            // 
            this.lblbankinh.AutoSize = true;
            this.lblbankinh.Location = new System.Drawing.Point(111, 133);
            this.lblbankinh.Name = "lblbankinh";
            this.lblbankinh.Size = new System.Drawing.Size(51, 13);
            this.lblbankinh.TabIndex = 5;
            this.lblbankinh.Text = "Bán kính";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(118, 224);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(44, 13);
            this.lblkq.TabIndex = 6;
            this.lblkq.Text = "Kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kết quả";
            // 
            // btnchuvi
            // 
            this.btnchuvi.Location = new System.Drawing.Point(249, 260);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(75, 23);
            this.btnchuvi.TabIndex = 8;
            this.btnchuvi.Text = "CHU VI";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // btbthoat
            // 
            this.btbthoat.Location = new System.Drawing.Point(249, 313);
            this.btbthoat.Name = "btbthoat";
            this.btbthoat.Size = new System.Drawing.Size(75, 23);
            this.btbthoat.TabIndex = 9;
            this.btbthoat.Text = "Thoát";
            this.btbthoat.UseVisualStyleBackColor = true;
            this.btbthoat.Click += new System.EventHandler(this.btbthoat_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(196, 176);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 10;
            // 
            // rdbdientich
            // 
            this.rdbdientich.AutoSize = true;
            this.rdbdientich.Location = new System.Drawing.Point(6, 30);
            this.rdbdientich.Name = "rdbdientich";
            this.rdbdientich.Size = new System.Drawing.Size(99, 17);
            this.rdbdientich.TabIndex = 0;
            this.rdbdientich.TabStop = true;
            this.rdbdientich.Text = "Tính Diện Tích";
            this.rdbdientich.UseVisualStyleBackColor = true;
            // 
            // rdbchuvi
            // 
            this.rdbchuvi.AutoSize = true;
            this.rdbchuvi.Location = new System.Drawing.Point(6, 55);
            this.rdbchuvi.Name = "rdbchuvi";
            this.rdbchuvi.Size = new System.Drawing.Size(82, 17);
            this.rdbchuvi.TabIndex = 1;
            this.rdbchuvi.TabStop = true;
            this.rdbchuvi.Text = "Tính Chu Vi";
            this.rdbchuvi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbchuvi);
            this.groupBox2.Controls.Add(this.cbdientich);
            this.groupBox2.Location = new System.Drawing.Point(608, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Chức Năng";
            // 
            // cbdientich
            // 
            this.cbdientich.AutoSize = true;
            this.cbdientich.Location = new System.Drawing.Point(16, 30);
            this.cbdientich.Name = "cbdientich";
            this.cbdientich.Size = new System.Drawing.Size(100, 17);
            this.cbdientich.TabIndex = 0;
            this.cbdientich.Text = "Tính Diện Tích";
            this.cbdientich.UseVisualStyleBackColor = true;
            // 
            // cbchuvi
            // 
            this.cbchuvi.AutoSize = true;
            this.cbchuvi.Location = new System.Drawing.Point(16, 56);
            this.cbchuvi.Name = "cbchuvi";
            this.cbchuvi.Size = new System.Drawing.Size(83, 17);
            this.cbchuvi.TabIndex = 1;
            this.cbchuvi.Text = "Tính Chu Vi";
            this.cbchuvi.UseVisualStyleBackColor = true;
            // 
            // btnloai1
            // 
            this.btnloai1.Location = new System.Drawing.Point(472, 224);
            this.btnloai1.Name = "btnloai1";
            this.btnloai1.Size = new System.Drawing.Size(75, 23);
            this.btnloai1.TabIndex = 11;
            this.btnloai1.Text = "Tính loại 1";
            this.btnloai1.UseVisualStyleBackColor = true;
            this.btnloai1.Click += new System.EventHandler(this.btnloai1_Click);
            // 
            // btnloai2
            // 
            this.btnloai2.Location = new System.Drawing.Point(624, 224);
            this.btnloai2.Name = "btnloai2";
            this.btnloai2.Size = new System.Drawing.Size(75, 23);
            this.btnloai2.TabIndex = 12;
            this.btnloai2.Text = "Tính loại 2";
            this.btnloai2.UseVisualStyleBackColor = true;
            this.btnloai2.Click += new System.EventHandler(this.btnloai2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnloai2);
            this.Controls.Add(this.btnloai1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.btbthoat);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.lblbankinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbankinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndientich);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblbankinh;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.Button btbthoat;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.RadioButton rdbdientich;
        private System.Windows.Forms.RadioButton rdbchuvi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbchuvi;
        private System.Windows.Forms.CheckBox cbdientich;
        private System.Windows.Forms.Button btnloai1;
        private System.Windows.Forms.Button btnloai2;
    }
}

