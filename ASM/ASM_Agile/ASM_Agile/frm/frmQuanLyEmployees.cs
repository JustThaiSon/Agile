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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASM_Agile.frm
{
	public partial class frmQuanLyEmployees : Form
	{
		private QuanLyNhanVienService sv;
		public frmQuanLyEmployees()
		{
			InitializeComponent();
			sv = new QuanLyNhanVienService();
			LoadGrid();
			LoadCBB();
		}
		private void LoadGrid()
		{
			string[] columnHeaders = { "Mã NV", "Họ Tên", "Tên Tài Khoản", "Mật Khẩu", "Email",
							   "Ngày Sinh", "Tên Quản Lý", "Địa Chỉ", "Số Điện Thoại", "Giới Tính" };
			dtg_DanhSach.Rows.Clear();
			dtg_DanhSach.Columns.Clear();

			foreach (string header in columnHeaders)
			{
				dtg_DanhSach.Columns.Add(header, header);
			}

			foreach (var item in sv.GetlstEmployees())
			{
				dtg_DanhSach.Rows.Add(item.EmployeeId, $"{item.LastName} {item.FirstName}", item.Account,
										item.Pass, item.Email, item.Birtdate,
										sv.GetlstManagers().Where(a => a.ManagerId == item.ManagerId)
										.Select(a => $"{a.LastName} {a.FirstName}").FirstOrDefault(),
										item.Address, item.PhoneNumber, item.Gender);
			}
		}
		private void LoadCBB()
		{
			foreach (var item in sv.GetlstManagers())
			{
				cbbTenQuanLy.Items.Add($"{item.LastName}  {item.FirstName}");
			}
			cbbTenQuanLy.SelectedIndex = 0;
		}
		private void Clear()
		{
			txtMaNV.Clear();
			txtTenNhanVien.Clear();
			txtTaiKhoan.Clear();
			txtMatKhau.Clear();
			txtEmail.Clear();
			DTNgaySinh.Text = "";
			cbbTenQuanLy.Text = "";
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
			Employees employees = new Employees();
			employees.EmployeeId = int.Parse(txtMaNV.Text);
			string[] fullName = txtTenNhanVien.Text.Split(new char[] { ' ' }, 2);
			if (fullName.Length >= 1)
			{
				employees.FirstName = fullName[0];
			}
			if (fullName.Length >= 2)
			{
				employees.LastName = fullName[1];
			}
			employees.Account = txtTaiKhoan.Text;
			employees.Pass = txtMatKhau.Text;
			employees.Email = txtEmail.Text;
			employees.Birtdate = DateTime.Parse(DTNgaySinh.Text);
			employees.ManagerId = sv.GetlstManagers().FirstOrDefault(a => $"{a.LastName}  {a.FirstName}" == cbbTenQuanLy.Text)?.ManagerId ?? 0;
			employees.Address = txtDiaChi.Text;
			employees.PhoneNumber = txtSDT.Text;
			employees.Gender = rdNam.Checked ? "Nam" : rdNu.Checked ? "Nữ" : "";
			MessageBox.Show(sv.Update(employees), "Thông Báo");
			Clear();
			LoadGrid();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

			int ID = int.Parse(txtMaNV.Text);
			MessageBox.Show(sv.Delete(ID), "Thông Báo");
			LoadGrid();
			Clear();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Employees employees = new Employees();
			employees.EmployeeId = int.Parse(txtMaNV.Text);
			string[] fullName = txtTenNhanVien.Text.Split(new char[] { ' ' }, 2);
			if (fullName.Length >= 1)
			{
				employees.FirstName = fullName[0];
			}
			if (fullName.Length >= 2)
			{
				employees.LastName = fullName[1];
			}
			employees.Account = txtTaiKhoan.Text;
			employees.Pass = txtMatKhau.Text;
			employees.Email = txtEmail.Text;
			employees.Birtdate = DateTime.Parse(DTNgaySinh.Text.ToString());
			employees.ManagerId = sv.GetlstManagers().FirstOrDefault(a => $"{a.LastName}  {a.FirstName}" == cbbTenQuanLy.Text)?.ManagerId ?? 0;
			employees.Address = txtDiaChi.Text;
			employees.PhoneNumber = txtSDT.Text;
			employees.Gender = rdNam.Checked ? "True" : rdNu.Checked ? "False" : "";
			MessageBox.Show(sv.Save(employees), "Thông Báo");
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

		private void dtg_DanhSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex >= 0 && rowIndex < dtg_DanhSach.Rows.Count - 1)
			{
				DataGridViewRow selectedRow = dtg_DanhSach.Rows[rowIndex];
				txtMaNV.Text = selectedRow.Cells[0].Value.ToString();
				txtTenNhanVien.Text = selectedRow.Cells[1].Value.ToString();
				txtTaiKhoan.Text = selectedRow.Cells[2].Value.ToString();
				txtMatKhau.Text = selectedRow.Cells[3].Value.ToString();
				txtEmail.Text = selectedRow.Cells[4].Value.ToString();
				DTNgaySinh.Text = selectedRow.Cells[5].Value.ToString();
				cbbTenQuanLy.Text = selectedRow.Cells[6].Value.ToString();
				txtDiaChi.Text = selectedRow.Cells[7].Value.ToString();
				txtSDT.Text = selectedRow.Cells[8].Value.ToString();
				string gioiTinh = selectedRow.Cells[9].Value.ToString();
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

		private void frmQuanLyEmployees_Load(object sender, EventArgs e)
		{

		}
	}
}