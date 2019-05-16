namespace QuanLyShipper
{
	partial class AlterShipper
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
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_alter = new System.Windows.Forms.Button();
            this.cbx_khuvuc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_birthday = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Phái = new System.Windows.Forms.Label();
            this.check_phai = new System.Windows.Forms.CheckBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_maShipper = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(632, 360);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(82, 39);
            this.btn_del.TabIndex = 42;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_alter
            // 
            this.btn_alter.Location = new System.Drawing.Point(499, 360);
            this.btn_alter.Name = "btn_alter";
            this.btn_alter.Size = new System.Drawing.Size(82, 39);
            this.btn_alter.TabIndex = 41;
            this.btn_alter.Text = "Sửa";
            this.btn_alter.UseVisualStyleBackColor = true;
            this.btn_alter.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbx_khuvuc
            // 
            this.cbx_khuvuc.FormattingEnabled = true;
            this.cbx_khuvuc.Location = new System.Drawing.Point(593, 241);
            this.cbx_khuvuc.Name = "cbx_khuvuc";
            this.cbx_khuvuc.Size = new System.Drawing.Size(121, 21);
            this.cbx_khuvuc.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(476, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Khu Vực";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(593, 188);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(93, 20);
            this.txt_mail.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(476, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Email";
            // 
            // txt_birthday
            // 
            this.txt_birthday.Location = new System.Drawing.Point(188, 284);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(93, 20);
            this.txt_birthday.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ngày Sinh";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(593, 138);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(93, 20);
            this.txt_sdt.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "SĐT";
            // 
            // Phái
            // 
            this.Phái.AutoSize = true;
            this.Phái.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phái.Location = new System.Drawing.Point(71, 239);
            this.Phái.Name = "Phái";
            this.Phái.Size = new System.Drawing.Size(67, 17);
            this.Phái.TabIndex = 32;
            this.Phái.Text = "Giới Tính";
            // 
            // check_phai
            // 
            this.check_phai.AutoSize = true;
            this.check_phai.Location = new System.Drawing.Point(188, 241);
            this.check_phai.Name = "check_phai";
            this.check_phai.Size = new System.Drawing.Size(91, 17);
            this.check_phai.TabIndex = 31;
            this.check_phai.Text = "(Nam *,Nữ \' \' )";
            this.check_phai.UseVisualStyleBackColor = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(188, 191);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(93, 20);
            this.txt_name.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mã Shipper";
            // 
            // cbx_maShipper
            // 
            this.cbx_maShipper.FormattingEnabled = true;
            this.cbx_maShipper.Location = new System.Drawing.Point(188, 141);
            this.cbx_maShipper.Name = "cbx_maShipper";
            this.cbx_maShipper.Size = new System.Drawing.Size(121, 21);
            this.cbx_maShipper.TabIndex = 43;
            this.cbx_maShipper.SelectedIndexChanged += new System.EventHandler(this.cbx_maShipper_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 34);
            this.label1.TabIndex = 44;
            this.label1.Text = "Sửa Shipper ";
            // 
            // AlterShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_maShipper);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_alter);
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
            this.Controls.Add(this.label2);
            this.Name = "AlterShipper";
            this.Text = "AlterShipper";
            this.Load += new System.EventHandler(this.AlterShipper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_del;
		private System.Windows.Forms.Button btn_alter;
		private System.Windows.Forms.ComboBox cbx_khuvuc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_mail;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_birthday;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_sdt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label Phái;
		private System.Windows.Forms.CheckBox check_phai;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbx_maShipper;
		private System.Windows.Forms.Label label1;
	}
}