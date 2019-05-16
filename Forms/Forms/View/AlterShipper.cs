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
	public partial class AlterShipper : Form
	{
		public AlterShipper()
		{
			InitializeComponent();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{

		}

        private void cbx_maShipper_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow selectedShipper = ((DataRowView)cbx_maShipper.SelectedItem).Row;
            txt_name.Text = selectedShipper["TenShipper"].ToString();
            check_phai.Checked = selectedShipper["GioiTinh"].ToString() == "True" ? true : false;
        }

        ShipperModel shipper = new ShipperModel();
        private void AlterShipper_Load(object sender, EventArgs e)
        {
            cbx_maShipper.DataSource = shipper.Load_On();
            cbx_maShipper.DisplayMember = "MaShipper";
            cbx_maShipper.ValueMember = "MaShipper";
        }
    }
}
