namespace Forms
{
	partial class AddShipper
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
			this.txt_maShipper = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.check_phai = new System.Windows.Forms.CheckBox();
			this.Phái = new System.Windows.Forms.Label();
			this.txt_sdt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_birthday = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_mail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbx_khuvuc = new System.Windows.Forms.ComboBox();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_reset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(277, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 34);
			this.label1.TabIndex = 2;
			this.label1.Text = "Thêm Shipper";
			// 
			// txt_maShipper
			// 
			this.txt_maShipper.Location = new System.Drawing.Point(157, 124);
			this.txt_maShipper.Name = "txt_maShipper";
			this.txt_maShipper.Size = new System.Drawing.Size(93, 20);
			this.txt_maShipper.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Mã Shipper";
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(157, 174);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(93, 20);
			this.txt_name.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(40, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Họ Tên";
			// 
			// check_phai
			// 
			this.check_phai.AutoSize = true;
			this.check_phai.Location = new System.Drawing.Point(157, 224);
			this.check_phai.Name = "check_phai";
			this.check_phai.Size = new System.Drawing.Size(91, 17);
			this.check_phai.TabIndex = 12;
			this.check_phai.Text = "(Nam *,Nữ \' \' )";
			this.check_phai.UseVisualStyleBackColor = true;
			this.check_phai.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Phái
			// 
			this.Phái.AutoSize = true;
			this.Phái.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Phái.Location = new System.Drawing.Point(40, 222);
			this.Phái.Name = "Phái";
			this.Phái.Size = new System.Drawing.Size(67, 17);
			this.Phái.TabIndex = 13;
			this.Phái.Text = "Giới Tính";
			// 
			// txt_sdt
			// 
			this.txt_sdt.Location = new System.Drawing.Point(562, 121);
			this.txt_sdt.Name = "txt_sdt";
			this.txt_sdt.Size = new System.Drawing.Size(93, 20);
			this.txt_sdt.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(445, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 17);
			this.label4.TabIndex = 14;
			this.label4.Text = "SĐT";
			// 
			// txt_birthday
			// 
			this.txt_birthday.Location = new System.Drawing.Point(157, 267);
			this.txt_birthday.Name = "txt_birthday";
			this.txt_birthday.Size = new System.Drawing.Size(93, 20);
			this.txt_birthday.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(40, 267);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 17);
			this.label5.TabIndex = 16;
			this.label5.Text = "Ngày Sinh";
			// 
			// txt_mail
			// 
			this.txt_mail.Location = new System.Drawing.Point(562, 171);
			this.txt_mail.Name = "txt_mail";
			this.txt_mail.Size = new System.Drawing.Size(93, 20);
			this.txt_mail.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(445, 171);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 17);
			this.label6.TabIndex = 18;
			this.label6.Text = "Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(445, 224);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 17);
			this.label7.TabIndex = 20;
			this.label7.Text = "Khu Vực";
			// 
			// cbx_khuvuc
			// 
			this.cbx_khuvuc.FormattingEnabled = true;
			this.cbx_khuvuc.Location = new System.Drawing.Point(562, 224);
			this.cbx_khuvuc.Name = "cbx_khuvuc";
			this.cbx_khuvuc.Size = new System.Drawing.Size(121, 21);
			this.cbx_khuvuc.TabIndex = 22;
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(468, 343);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(82, 39);
			this.btn_add.TabIndex = 25;
			this.btn_add.Text = "Thêm";
			this.btn_add.UseVisualStyleBackColor = true;
			// 
			// btn_reset
			// 
			this.btn_reset.Location = new System.Drawing.Point(601, 343);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(82, 39);
			this.btn_reset.TabIndex = 26;
			this.btn_reset.Text = "Hủy";
			this.btn_reset.UseVisualStyleBackColor = true;
			// 
			// AddShipper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(763, 450);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.cbx_khuvuc);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_mail);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_birthday);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_sdt);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Phái);
			this.Controls.Add(this.check_phai);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_maShipper);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddShipper";
			this.Text = "AddShipper";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_maShipper;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox check_phai;
		private System.Windows.Forms.Label Phái;
		private System.Windows.Forms.TextBox txt_sdt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_birthday;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_mail;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbx_khuvuc;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_reset;
	}
}