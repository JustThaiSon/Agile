using ASM_Agile.Context;
using ASM_Agile.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_Agile.Service
{
	 class QuanLySanPhamService
	{
		private readonly DBContext dbContext;
		private List<Phones> phones;
		private readonly List<Brands> brands;
		private readonly List<NhaSanXuat> nhaSanXuat;

		public QuanLySanPhamService()
		{
			dbContext = new DBContext();
			brands = dbContext.Brands.ToList();
			nhaSanXuat = dbContext.NhaSanXuat.ToList();
			GetPhonesDB();
		}

		public void GetPhonesDB()
		{
			phones = dbContext.Phones.ToList();
		}

		public List<Phones> GetPhones()
		{
			return phones;
		}

		public List<Brands> GetBrands()
		{
			return brands;
		}

		public List<NhaSanXuat> GetNhaSanXuat()
		{
			return nhaSanXuat;
		}

		public string Delete(int id)
		{
			try
			{
				var phoneToDelete = dbContext.Phones
					.Include(p => p.PhoneCategories)
					.Include(p => p.PhoneCustomers)
					.Include(p => p.PhoneEmployees)
					.FirstOrDefault(p => p.PhoneId == id);

				if (phoneToDelete != null)
				{
					dbContext.PhoneCategories.RemoveRange(phoneToDelete.PhoneCategories);
					dbContext.PhoneCustomers.RemoveRange(phoneToDelete.PhoneCustomers);
					dbContext.PhoneEmployees.RemoveRange(phoneToDelete.PhoneEmployees);
					dbContext.Phones.Remove(phoneToDelete);
					dbContext.SaveChanges();
					GetPhonesDB();
					return "Xóa Thành Công";
				}
				else
				{
					return $"Không Tìm Thấy ID {id}";
				}
			}
			catch (Exception ex)
			{
				return "Lỗi Khi Xóa";
			}
		}

		public string Save(Phones phone)
		{
			if (dbContext.Phones.Any(p => p.PhoneId == phone.PhoneId))
			{
				return "ID Đã Tồn Tại";
			}
			else
			{
				dbContext.Phones.Add(phone);
				dbContext.SaveChanges();
				GetPhonesDB();
				return "Save Thành Công";
			}
		}

		public string Update(Phones phone)
		{
			var existingPhone = dbContext.Phones.FirstOrDefault(p => p.PhoneId == phone.PhoneId);
			if (existingPhone != null)
			{
				existingPhone.Model = phone.Model;
				existingPhone.Price = phone.Price;
				existingPhone.StockQuantity = phone.StockQuantity;
				existingPhone.BrandId = phone.BrandId;
				existingPhone.NhanSanXuatId = phone.NhanSanXuatId;
				dbContext.SaveChanges();
				GetPhonesDB();
				return "Update Thành Công!";
			}
			else
			{
				return "Không Tìm Thấy ID Cần Update";
			}
		}
	}
}
