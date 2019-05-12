namespace Forms
{
	partial class ThongKeDoanhThu
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
			this.cbx_maShipper = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.date_End = new System.Windows.Forms.DateTimePicker();
			this.date_Start = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(265, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(319, 34);
			this.label1.TabIndex = 3;
			this.label1.Text = "Thống Kê Doanh Thu ";
			// 
			// cbx_maShipper
			// 
			this.cbx_maShipper.FormattingEnabled = true;
			this.cbx_maShipper.Location = new System.Drawing.Point(185, 114);
			this.cbx_maShipper.Name = "cbx_maShipper";
			this.cbx_maShipper.Size = new System.Drawing.Size(121, 21);
			this.cbx_maShipper.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "Mã Shipper";
			// 
			// date_End
			// 
			this.date_End.Location = new System.Drawing.Point(537, 152);
			this.date_End.Name = "date_End";
			this.date_End.Size = new System.Drawing.Size(200, 20);
			this.date_End.TabIndex = 36;
			// 
			// date_Start
			// 
			this.date_Start.Location = new System.Drawing.Point(537, 111);
			this.date_Start.Name = "date_Start";
			this.date_Start.Size = new System.Drawing.Size(200, 20);
			this.date_Start.TabIndex = 35;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(407, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 17);
			this.label4.TabIndex = 34;
			this.label4.Text = "Đến Ngày";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(407, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 17);
			this.label2.TabIndex = 33;
			this.label2.Text = "Từ Ngày";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(50, 196);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(671, 242);
			this.dataGridView1.TabIndex = 37;
			// 
			// ThongKeDoanhThu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.date_End);
			this.Controls.Add(this.date_Start);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbx_maShipper);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "ThongKeDoanhThu";
			this.Text = "ThongKeDoanhThu";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbx_maShipper;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker date_End;
		private System.Windows.Forms.DateTimePicker date_Start;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}