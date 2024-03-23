﻿using ASM_Agile.Context;
using ASM_Agile.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_Agile.Service
{
	 class QuanLyKhachHangService
	{
		private DBContext _dbcontext;
		private List<Customers> _lstCutomers;
		public QuanLyKhachHangService()
		{
			_dbcontext = new DBContext();
			_lstCutomers = new List<Customers>();
			GetCustomersDB();
		}
		public void GetCustomersDB()
		{
			_lstCutomers = _dbcontext.Customers.ToList();
		}
		public List<Customers> GetCustomers()
		{
			return _lstCutomers;
		}
		public string Update(Customers c)
		{

			var Exists = _lstCutomers.FirstOrDefault(a => a.CustomerId == c.CustomerId);
			if (Exists != null)
			{
				Exists.FirstName = c.FirstName;
				Exists.LastName = c.LastName;
				Exists.Email = c.Email;
				Exists.Birtdate = c.Birtdate;
				Exists.Account = c.Account;
				Exists.Pass = c.Pass;
				Exists.Address = c.Address;
				Exists.Gender = c.Gender;
				Exists.PhoneNumber = c.PhoneNumber;
				_dbcontext.SaveChanges();
				GetCustomersDB();
			}
			return "Update Thành Công";
		}
		public string Delete(int ID)
		{
			var Delete = _dbcontext.Customers.FirstOrDefault(a => a.CustomerId == ID);
			if (Delete != null)
			{
				_dbcontext.Remove(Delete);
				_dbcontext.SaveChanges();
				GetCustomersDB();
			}
			return "Xóa Thành Công";
		}
		public string Save(Customers c)
		{
			_dbcontext.Add(c);
			_dbcontext.SaveChanges();
			GetCustomersDB();
			return "Lưu Thành Công";
		}
	}
}

