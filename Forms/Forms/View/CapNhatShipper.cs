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
	public partial class CapNhatShipper : Form
	{
		public CapNhatShipper()
		{
			InitializeComponent();
		}

        private void btn_them_Click(object sender, EventArgs e)
        {
            AddShipper f = new AddShipper();
            f.Show();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            AlterShipper f = new AlterShipper();
            f.Show();
        }
    }
}
