namespace BuiHuuLoc_BaiTapChuong3
{
    partial class Form4
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
            this.lblHienThi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHoLot = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoVaTen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHienThi.Location = new System.Drawing.Point(0, 0);
            this.lblHienThi.MinimumSize = new System.Drawing.Size(500, 50);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(500, 50);
            this.lblHienThi.TabIndex = 0;
            this.lblHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Lót";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(162, 66);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(266, 22);
            this.txtHo.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(162, 109);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(266, 22);
            this.txtTen.TabIndex = 4;
            // 
            // btnHoLot
            // 
            this.btnHoLot.Location = new System.Drawing.Point(78, 160);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(87, 28);
            this.btnHoLot.TabIndex = 5;
            this.btnHoLot.Text = "Họ Lót";
            this.btnHoLot.UseVisualStyleBackColor = true;
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(215, 160);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(87, 28);
            this.btnTen.TabIndex = 6;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoVaTen
            // 
            this.btnHoVaTen.Location = new System.Drawing.Point(341, 160);
            this.btnHoVaTen.Name = "btnHoVaTen";
            this.btnHoVaTen.Size = new System.Drawing.Size(87, 28);
            this.btnHoVaTen.TabIndex = 7;
            this.btnHoVaTen.Text = "Họ Tên";
            this.btnHoVaTen.UseVisualStyleBackColor = true;
            this.btnHoVaTen.Click += new System.EventHandler(this.btnHoVaTen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(175, 222);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(155, 28);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát chương trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 262);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoVaTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHoLot);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHienThi);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHoLot;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoVaTen;
        private System.Windows.Forms.Button btnThoat;
    }
}