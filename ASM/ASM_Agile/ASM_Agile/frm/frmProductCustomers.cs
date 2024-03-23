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
	public partial class frmProductCustomers : Form
	{
		private QuanLySanPhamService sv;
		public frmProductCustomers()
		{
			InitializeComponent();
			sv = new QuanLySanPhamService();
			LoadGrid();
		}
		private void LoadGrid()
		{
			string[] columnHeaders = { "PhoneID", "Tên Sản Phẩm", "Tên Brand", "Tên Nhà Sản Xuất", "Số Lượng",
							   "Giá"};
			dtg_DanhSach.Rows.Clear();
			dtg_DanhSach.Columns.Clear();

			foreach (string header in columnHeaders)
			{
				dtg_DanhSach.Columns.Add(header, header);
			}
			foreach (var item in sv.GetPhones())
			{
				dtg_DanhSach.Rows.Add(item.PhoneId, item.Model, sv.GetBrands().Where(a => a.BrandId == item.BrandId).Select(a => a.BrandName).FirstOrDefault(),
					sv.GetNhaSanXuat().Where(a => a.NhaSanXuatId == item.NhanSanXuatId).Select(a => a.TenNhaSanXuat).FirstOrDefault(), item.StockQuantity, item.Price);
			}
		}
		private void btnExits_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmMenuManagers form = new frmMenuManagers();
			form.ShowDialog();
			Application.Exit();

		}


		private void dtg_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int Index = e.RowIndex;
			if (Index >= 0 && Index < dtg_DanhSach.Rows.Count - 1)
			{
				DataGridViewRow selectedRow = dtg_DanhSach.Rows[Index];
				txtPhoneID.Text = selectedRow.Cells[0].Value.ToString();
				txtTenSanPham.Text = selectedRow.Cells[1].Value.ToString();
				txtSoLuong.Text = selectedRow.Cells[4].Value.ToString();
				txtGia.Text = selectedRow.Cells[5].Value.ToString();
				txtNhaSanXuat.Text = selectedRow.Cells[3].Value.ToString();
				txtTenBrand.Text = selectedRow.Cells[2].Value.ToString();
			}
		}
		private void Clear()
		{
			txtGia.Clear();
			txtSoLuong.Clear();
			txtPhoneID.Clear();
			txtTenSanPham.Clear();
			txtTenBrand.Clear();
			txtNhaSanXuat.Clear();
		}
		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Giỏ Hàng!!!");
			this.Hide();
			Card form = new Card();
			form.ShowDialog();
			Application.Exit();

		}
	}
}
