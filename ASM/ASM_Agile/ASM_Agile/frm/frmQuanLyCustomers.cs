using ASM_Agile.DomainClass;
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
	public partial class frmQuanLyCustomers : Form
	{
		private QuanLyKhachHangService sv;

		public frmQuanLyCustomers()
		{
			InitializeComponent();
			sv = new QuanLyKhachHangService();
			LoadGrid();
		}
		private void LoadGrid()
		{
			string[] columnHeaders = { "Mã KH", "Họ Tên", "Tên Tài Khoản", "Mật Khẩu", "Email",
							   "Ngày Sinh", "Địa Chỉ", "Số Điện Thoại", "Giới Tính" };
			dtg_DanhSach.Rows.Clear();
			dtg_DanhSach.Columns.Clear();

			foreach (string header in columnHeaders)
			{
				dtg_DanhSach.Columns.Add(header, header);
			}

			foreach (var item in sv.GetCustomers())
			{
				dtg_DanhSach.Rows.Add(item.CustomerId, $"{item.LastName} {item.FirstName}", item.Account,
										item.Pass, item.Email, item.Birtdate,
										item.Address, item.PhoneNumber, item.Gender);
			}
		}

		private void dtg_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex >= 0 && rowIndex < dtg_DanhSach.Rows.Count - 1)
			{
				DataGridViewRow selectedRow = dtg_DanhSach.Rows[rowIndex];
				txtMaKH.Text = selectedRow.Cells[0].Value.ToString();
				txtTenKhachHang.Text = selectedRow.Cells[1].Value.ToString();
				txtTaiKhoan.Text = selectedRow.Cells[2].Value.ToString();
				txtMatKhau.Text = selectedRow.Cells[3].Value.ToString();
				txtEmail.Text = selectedRow.Cells[4].Value.ToString();
				DTNgaySinh.Text = selectedRow.Cells[5].Value.ToString();
				txtDiaChi.Text = selectedRow.Cells[6].Value.ToString();
				txtSDT.Text = selectedRow.Cells[7].Value.ToString();
				string gioiTinh = selectedRow.Cells[8].Value.ToString();
				if (gioiTinh == "True")
				{
					rdNam.Checked = true;
					rdNu.Checked = false;
				}
				else if (gioiTinh == "False")
				{
					rdNam.Checked = false;
					rdNu.Checked = true;
				}
				else
				{
					rdNam.Checked = false;
					rdNu.Checked = false;
				}
			}
		}
		private void Clear()
		{
			txtTenKhachHang.Clear();
			txtMaKH.Clear();
			txtTaiKhoan.Clear();
			txtMatKhau.Clear();
			txtEmail.Clear();
			DTNgaySinh.Text = "";
			txtDiaChi.Clear();
			txtSDT.Clear();
			rdNam.Checked = false;
			rdNu.Checked = false;
			btnDelete.Enabled = true;
			btnEdit.Enabled = true;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			Clear();
			btnDelete.Enabled = false;
			btnEdit.Enabled = false;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Customers ct = new Customers();
			ct.CustomerId = int.Parse(txtMaKH.Text);
			string[] fullName = txtTenKhachHang.Text.Split(new char[] { ' ' }, 2);
			if (fullName.Length >= 1)
			{
				ct.FirstName = fullName[0];
			}
			if (fullName.Length >= 2)
			{
				ct.LastName = fullName[1];
			}
			ct.Account = txtTaiKhoan.Text;
			ct.Pass = txtMatKhau.Text;
			ct.Email = txtEmail.Text;
			ct.Birtdate = DateTime.Parse(DTNgaySinh.Text.ToString());
			ct.Address = txtDiaChi.Text;
			ct.PhoneNumber = txtSDT.Text;
			ct.Gender = rdNam.Checked ? "True" : rdNu.Checked ? "False" : "";
			MessageBox.Show(sv.Update(ct), "Thông Báo");
			Clear();
			LoadGrid();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int ID = int.Parse(txtMaKH.Text);
			MessageBox.Show(sv.Delete(ID), "Thông Báo");
			LoadGrid();
			Clear();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Customers ct = new Customers();
			ct.CustomerId = int.Parse(txtMaKH.Text);
			string[] fullName = txtTenKhachHang.Text.Split(new char[] { ' ' }, 2);
			if (fullName.Length >= 1)
			{
				ct.FirstName = fullName[0];
			}
			if (fullName.Length >= 2)
			{
				ct.LastName = fullName[1];
			}
			ct.Account = txtTaiKhoan.Text;
			ct.Pass = txtMatKhau.Text;
			ct.Email = txtEmail.Text;
			ct.Birtdate = DateTime.Parse(DTNgaySinh.Text.ToString());
			ct.Address = txtDiaChi.Text;
			ct.PhoneNumber = txtSDT.Text;
			ct.Gender = rdNam.Checked ? "True" : rdNu.Checked ? "False" : "";
			MessageBox.Show(sv.Save(ct), "Thông Báo");
			Clear();
			LoadGrid();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnExits_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmMenuManagers form = new frmMenuManagers();
			form.ShowDialog();
			Application.Exit();

		}
	}
}
