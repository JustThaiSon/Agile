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
	public partial class frmQuanLyProduct : Form
	{
		private QuanLySanPhamService sv;
		public frmQuanLyProduct()
		{
			InitializeComponent();
			sv = new QuanLySanPhamService();
			LoadCbbBrandname();
			LoadCbbNhaSanXuat();
			LoadGrid();
		}
		private void LoadCbbBrandname()
		{
			foreach (var item in sv.GetBrands())
			{
				cbbTenBrand.Items.Add(item.BrandName);
			}
			cbbTenBrand.SelectedIndex = -1;
		}
		private void LoadCbbNhaSanXuat()
		{
			foreach (var item in sv.GetNhaSanXuat())
			{
				cbbNhaSanXuat.Items.Add(item.TenNhaSanXuat);
			}
			cbbNhaSanXuat.SelectedIndex = -1;
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
		private void Clear()
		{
			txtGia.Clear();
			txtSoLuong.Clear();
			txtPhoneID.Clear();
			txtTenSanPham.Clear();
			cbbTenBrand.Text = "";
			cbbNhaSanXuat.Text = "";
			btnDelete.Enabled = true;
			btnEdit.Enabled = true;
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
				cbbNhaSanXuat.Text = selectedRow.Cells[3].Value.ToString();
				cbbTenBrand.Text = selectedRow.Cells[2].Value.ToString();
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			Clear();
			btnDelete.Enabled = false;
			btnEdit.Enabled = false;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtPhoneID.Text))
			{
				MessageBox.Show("Vui lòng chọn một điện thoại để sửa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Phones p = new Phones();
			p.PhoneId = int.Parse(txtPhoneID.Text.ToString());
			p.Price = decimal.Parse(txtGia.Text);
			p.StockQuantity = int.Parse(txtSoLuong.Text);
			p.Model = txtTenSanPham.Text;
			p.BrandId = sv.GetBrands().FirstOrDefault(b => b.BrandName == cbbTenBrand.Text)?.BrandId ?? 0;
			p.NhanSanXuatId = sv.GetNhaSanXuat().FirstOrDefault(n => n.TenNhaSanXuat == cbbNhaSanXuat.Text)?.NhaSanXuatId ?? 0;
			string result = sv.Update(p);
			MessageBox.Show(result, "Thông Báo");
			Clear();
			LoadGrid();

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int ID = int.Parse(txtPhoneID.Text.ToString());
			MessageBox.Show(sv.Delete(ID), "Thông Báo");
			Clear();
			LoadGrid();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Phones p = new Phones();
			p.PhoneId = int.Parse(txtPhoneID.Text.ToString());
			p.Price = int.Parse(txtGia.Text.ToString());
			p.StockQuantity = int.Parse(txtSoLuong.Text.ToString());
			p.Model = txtTenSanPham.Text;
			p.BrandId = sv.GetBrands().Where(a => a.BrandName == cbbTenBrand.Text).Select(a => a.BrandId).FirstOrDefault();
			if (!sv.GetBrands().Any(a => a.BrandId == p.BrandId))
			{
				MessageBox.Show("BrandName Không tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			p.NhanSanXuatId = sv.GetNhaSanXuat().Where(a => a.TenNhaSanXuat == cbbNhaSanXuat.Text).Select(a => a.NhaSanXuatId).FirstOrDefault();
			if (!sv.GetNhaSanXuat().Any(a => a.NhaSanXuatId == p.NhanSanXuatId))
			{
				MessageBox.Show("Nhà Sản Xuất không tồn tại Không tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			MessageBox.Show(sv.Save(p), "Thông Báo");
			Clear();
			LoadGrid();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{

			this.Hide();
			frmMenuManagers form = new frmMenuManagers();
			form.ShowDialog();
			Application.Exit();
		}
	}
}
