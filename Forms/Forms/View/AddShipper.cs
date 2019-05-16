using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShipper.Controller;

namespace QuanLyShipper
{
	public partial class AddShipper : Form
	{
		public AddShipper()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }

        ShipperController shipper = new ShipperController();
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_maShipper.Text == "" && txt_tenShipper.Text == "")
            {
                MessageBox.Show("Không thể thêm nếu không có dữ liệu.");
            }
            else
            {
                if (shipper.Add_Shipper(txt_maShipper.Text, txt_tenShipper.Text, "1",txt_mail.Text,txt_birthday.Text,txt_sdt.Text,cbx_Quan.Text,"1"))
                {
                    MessageBox.Show("Thêm mới shipper thành công");
                }
                else
                {
                    MessageBox.Show("Thêm mới không thành công!");
                }
                    
            }
        }

        private void cbx_City_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        ShipperModel shipper1 = new ShipperModel();
        private void AddShipper_Load(object sender, EventArgs e)
        {
            cbx_City.DataSource = shipper1.load_City();
            cbx_City.ValueMember = "id";
            cbx_City.DisplayMember = "KhuVuc";
        }
    }
}
