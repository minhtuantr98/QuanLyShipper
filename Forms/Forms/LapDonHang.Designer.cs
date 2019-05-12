namespace Forms
{
	partial class LapDonHang
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
			this.label2 = new System.Windows.Forms.Label();
			this.txt_maDH = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_maNV = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_tenKH = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_sdt = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_moTa = new System.Windows.Forms.TextBox();
			this.txt_tienHang = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_tienShip = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_tongTien = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.login_btn = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.Cbx_City = new System.Windows.Forms.ComboBox();
			this.Cbx_Quan = new System.Windows.Forms.ComboBox();
			this.Cbx_Phuong = new System.Windows.Forms.ComboBox();
			this.Cbx_diaChi = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cbx_maShipper = new System.Windows.Forms.ComboBox();
			this.txt_date = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(276, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 34);
			this.label1.TabIndex = 1;
			this.label1.Text = "Lập Đơn Hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Mã Đơn Hàng";
			// 
			// txt_maDH
			// 
			this.txt_maDH.Location = new System.Drawing.Point(136, 120);
			this.txt_maDH.Name = "txt_maDH";
			this.txt_maDH.Size = new System.Drawing.Size(93, 20);
			this.txt_maDH.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(19, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Mã Nhân Viên ";
			// 
			// txt_maNV
			// 
			this.txt_maNV.Location = new System.Drawing.Point(136, 167);
			this.txt_maNV.Name = "txt_maNV";
			this.txt_maNV.Size = new System.Drawing.Size(93, 20);
			this.txt_maNV.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(18, 214);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 17);
			this.label4.TabIndex = 10;
			this.label4.Text = "Tên Khách Hàng";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// txt_tenKH
			// 
			this.txt_tenKH.Location = new System.Drawing.Point(135, 211);
			this.txt_tenKH.Name = "txt_tenKH";
			this.txt_tenKH.Size = new System.Drawing.Size(165, 20);
			this.txt_tenKH.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(19, 291);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Địa Chỉ Giao";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(19, 248);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 17);
			this.label6.TabIndex = 14;
			this.label6.Text = "SĐT";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// txt_sdt
			// 
			this.txt_sdt.Location = new System.Drawing.Point(134, 248);
			this.txt_sdt.Name = "txt_sdt";
			this.txt_sdt.Size = new System.Drawing.Size(134, 20);
			this.txt_sdt.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(433, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 17);
			this.label7.TabIndex = 16;
			this.label7.Text = "Mô Tả Hàng";
			// 
			// txt_moTa
			// 
			this.txt_moTa.Location = new System.Drawing.Point(550, 149);
			this.txt_moTa.Multiline = true;
			this.txt_moTa.Name = "txt_moTa";
			this.txt_moTa.Size = new System.Drawing.Size(238, 67);
			this.txt_moTa.TabIndex = 17;
			this.txt_moTa.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// txt_tienHang
			// 
			this.txt_tienHang.Location = new System.Drawing.Point(550, 231);
			this.txt_tienHang.Name = "txt_tienHang";
			this.txt_tienHang.Size = new System.Drawing.Size(153, 20);
			this.txt_tienHang.TabIndex = 19;
			this.txt_tienHang.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(433, 231);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 17);
			this.label8.TabIndex = 18;
			this.label8.Text = "Tiền Hàng";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// txt_tienShip
			// 
			this.txt_tienShip.Location = new System.Drawing.Point(550, 268);
			this.txt_tienShip.Name = "txt_tienShip";
			this.txt_tienShip.Size = new System.Drawing.Size(153, 20);
			this.txt_tienShip.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(433, 271);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 17);
			this.label9.TabIndex = 20;
			this.label9.Text = "Phí Ship";
			// 
			// txt_tongTien
			// 
			this.txt_tongTien.Location = new System.Drawing.Point(550, 345);
			this.txt_tongTien.Name = "txt_tongTien";
			this.txt_tongTien.Size = new System.Drawing.Size(153, 20);
			this.txt_tongTien.TabIndex = 23;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(433, 345);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 17);
			this.label10.TabIndex = 22;
			this.label10.Text = "Tổng Tiền";
			// 
			// login_btn
			// 
			this.login_btn.Location = new System.Drawing.Point(550, 374);
			this.login_btn.Name = "login_btn";
			this.login_btn.Size = new System.Drawing.Size(82, 39);
			this.login_btn.TabIndex = 24;
			this.login_btn.Text = "Xác Nhận";
			this.login_btn.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(683, 374);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 39);
			this.button1.TabIndex = 25;
			this.button1.Text = "In Đơn Hàng";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Cbx_City
			// 
			this.Cbx_City.DisplayMember = "Alo";
			this.Cbx_City.FormattingEnabled = true;
			this.Cbx_City.Location = new System.Drawing.Point(134, 287);
			this.Cbx_City.Name = "Cbx_City";
			this.Cbx_City.Size = new System.Drawing.Size(95, 21);
			this.Cbx_City.TabIndex = 26;
			// 
			// Cbx_Quan
			// 
			this.Cbx_Quan.FormattingEnabled = true;
			this.Cbx_Quan.Location = new System.Drawing.Point(249, 287);
			this.Cbx_Quan.Name = "Cbx_Quan";
			this.Cbx_Quan.Size = new System.Drawing.Size(95, 21);
			this.Cbx_Quan.TabIndex = 27;
			// 
			// Cbx_Phuong
			// 
			this.Cbx_Phuong.FormattingEnabled = true;
			this.Cbx_Phuong.Location = new System.Drawing.Point(134, 324);
			this.Cbx_Phuong.Name = "Cbx_Phuong";
			this.Cbx_Phuong.Size = new System.Drawing.Size(95, 21);
			this.Cbx_Phuong.TabIndex = 28;
			// 
			// Cbx_diaChi
			// 
			this.Cbx_diaChi.Location = new System.Drawing.Point(134, 364);
			this.Cbx_diaChi.Name = "Cbx_diaChi";
			this.Cbx_diaChi.Size = new System.Drawing.Size(134, 20);
			this.Cbx_diaChi.TabIndex = 29;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(433, 307);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(58, 17);
			this.label11.TabIndex = 30;
			this.label11.Text = "Shipper";
			// 
			// cbx_maShipper
			// 
			this.cbx_maShipper.FormattingEnabled = true;
			this.cbx_maShipper.Location = new System.Drawing.Point(550, 307);
			this.cbx_maShipper.Name = "cbx_maShipper";
			this.cbx_maShipper.Size = new System.Drawing.Size(153, 21);
			this.cbx_maShipper.TabIndex = 32;
			// 
			// txt_date
			// 
			this.txt_date.Location = new System.Drawing.Point(550, 117);
			this.txt_date.Name = "txt_date";
			this.txt_date.Size = new System.Drawing.Size(93, 20);
			this.txt_date.TabIndex = 34;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(433, 117);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(69, 17);
			this.label12.TabIndex = 33;
			this.label12.Text = "Ngày Lập";
			// 
			// LapDonHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(803, 450);
			this.Controls.Add(this.txt_date);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.cbx_maShipper);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.Cbx_diaChi);
			this.Controls.Add(this.Cbx_Phuong);
			this.Controls.Add(this.Cbx_Quan);
			this.Controls.Add(this.Cbx_City);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.login_btn);
			this.Controls.Add(this.txt_tongTien);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txt_tienShip);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txt_tienHang);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txt_moTa);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_sdt);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_tenKH);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_maNV);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_maDH);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "LapDonHang";
			this.Text = "LapDonHang";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_maDH;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_maNV;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_tenKH;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_sdt;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_moTa;
		private System.Windows.Forms.TextBox txt_tienHang;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_tienShip;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_tongTien;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button login_btn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox Cbx_City;
		private System.Windows.Forms.ComboBox Cbx_Quan;
		private System.Windows.Forms.ComboBox Cbx_Phuong;
		private System.Windows.Forms.TextBox Cbx_diaChi;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cbx_maShipper;
		private System.Windows.Forms.TextBox txt_date;
		private System.Windows.Forms.Label label12;
	}
}