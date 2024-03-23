using ASM_Agile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_Agile.frm
{
	public partial class frmDangNhapCustomers : Form
	{
		private Account acc;
		public frmDangNhapCustomers()
		{
			InitializeComponent();
			acc = new Account();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string TaiKhoan = txtTaiKhoan.Text;
			string matKhau = txtmatKhau.Text;
			if (CheckAccountKhachHang(TaiKhoan, matKhau))
			{
				MessageBox.Show("Đăng Nhập Thành Công!!!");
				this.Hide();
				frmProductCustomers form = new frmProductCustomers();
				form.ShowDialog();
				Application.Exit();

			}
			else
			{
				MessageBox.Show("Đăng Nhập Thất Bại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private bool CheckAccountKhachHang(string username, string password)
		{
			return acc.CheckTaiKhoanKhachHang(username, password);
		}

		private void btnExits_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 form = new Form1();
			form.ShowDialog();
			Application.Exit();
		}
	}
}
