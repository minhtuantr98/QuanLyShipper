namespace Forms
{
	partial class TinhTrangHoatDong
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
			this.label5 = new System.Windows.Forms.Label();
			this.cbx_maShipper = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbx_khuVuc = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(231, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(320, 34);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tình Trạng Hoạt Động";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(35, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 17);
			this.label5.TabIndex = 29;
			this.label5.Text = "Khu Vực";
			// 
			// cbx_maShipper
			// 
			this.cbx_maShipper.FormattingEnabled = true;
			this.cbx_maShipper.Location = new System.Drawing.Point(569, 107);
			this.cbx_maShipper.Name = "cbx_maShipper";
			this.cbx_maShipper.Size = new System.Drawing.Size(121, 21);
			this.cbx_maShipper.TabIndex = 32;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(454, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 17);
			this.label2.TabIndex = 31;
			this.label2.Text = "Mã Shipper";
			// 
			// cbx_khuVuc
			// 
			this.cbx_khuVuc.FormattingEnabled = true;
			this.cbx_khuVuc.Location = new System.Drawing.Point(159, 108);
			this.cbx_khuVuc.Name = "cbx_khuVuc";
			this.cbx_khuVuc.Size = new System.Drawing.Size(121, 21);
			this.cbx_khuVuc.TabIndex = 33;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(38, 167);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(652, 243);
			this.dataGridView1.TabIndex = 34;
			// 
			// TinhTrangHoatDong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(740, 436);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cbx_khuVuc);
			this.Controls.Add(this.cbx_maShipper);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Name = "TinhTrangHoatDong";
			this.Text = "XemDonHang";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbx_maShipper;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbx_khuVuc;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}