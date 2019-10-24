using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BTL_WED.Models.Emty;
namespace BTL_WED.Models.Function
{
    public class F_Customer
    {
        private MyDBContext context;
        public F_Customer()
        {
            context = new MyDBContext();
        }
        //Trả về tất cả các bản ghi
        public IQueryable<Customer> DS_Customer
        {
            get { return context.Customers; }
        }
        //Trả về một đối tượng khi biết khóa
        public Customer FindEntity(int? Ma)
        {
            Customer dbEntry = context.Customers.Find(Ma);
            return dbEntry;
        }
        //Thêm một đối tượng
        public int? Insert(Customer model)
        {
            Customer dbEntry = context.Customers.Find(model.CustomerID);
            if (dbEntry != null)
            {
                return null;
            }

            context.Customers.Add(model);
            context.SaveChanges();
            return model.CustomerID;
        }
        // Sửa dữ liệu
        public int? Update(Customer model)
        {
            Customer dbEntry = context.Customers.Find(model.CustomerID);
            //   LoaiBanDoc dbEntry = context.LoaiBanDocs.
            //  Where(x => x.LoaiBanDoc1 = model.LoaiBanDoc1).FirstOrDefault();
            if (dbEntry == null)
            {
                return null;
            }
            dbEntry.Name = model.Name;
            dbEntry.Email = model.Email;
            dbEntry.PhoneNumber = model.PhoneNumber;
            dbEntry.Comment = model.Comment;
            dbEntry.HouseID = model.HouseID;
            context.SaveChanges();

            return model.CustomerID;
        }
        public int? Delete(int? Ma)
        {
            Customer dbEntry = context.Customers.Find(Ma);
            if (dbEntry == null)
            {
                return null;
            }
            context.Customers.Remove(dbEntry);

            context.SaveChanges();
            return Ma;
        }
    }
}