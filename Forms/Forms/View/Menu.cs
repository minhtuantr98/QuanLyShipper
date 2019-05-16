using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShipper
{
	public partial class fMenu : Form
	{
		public fMenu()
		{
			InitializeComponent();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void btn_statusGiao_Click(object sender, EventArgs e)
		{
            TinhTrangGiaoHang f = new TinhTrangGiaoHang();
            f.Show();
            Visible = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
            ThongKeKhuVuc f = new ThongKeKhuVuc();
            f.Show();
            Visible = false;
		}

		private void btn_thongKeTime_Click(object sender, EventArgs e)
		{
            ThongKeDoanhThu f = new ThongKeDoanhThu();
            f.Show();
            Visible = false;
		}

        private void btn_lapDH_Click(object sender, EventArgs e)
        {
            LapDonHang f = new LapDonHang();
            f.Show();
            Visible = false;
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            CapNhatShipper f = new CapNhatShipper();
            f.Show();
            Visible = false;
        }

        private void btn_statusOnOff_Click(object sender, EventArgs e)
        {
            TinhTrangHoatDong f = new TinhTrangHoatDong();
            f.Show();
            Visible = false;
        }

        private void btn_thongKeDonHang_Click(object sender, EventArgs e)
        {
            ThongKeDonHang f = new ThongKeDonHang();
            f.Show();
            Visible = false;
        }
    }
}
