using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BTL_WED.Models.Emty;
namespace BTL_WED.Models.Function
{
    public class F_House
    {
        private MyDBContext context;
        public F_House()
        {
            context = new MyDBContext();
        }
        //Trả về tất cả các bản ghi
        public IQueryable<House> DS_House
        {
            get { return context.Houses; }
        }
        //Trả về một đối tượng khi biết khóa
        public House FindEntity(int? Ma)
        {
            House dbEntry = context.Houses.Find(Ma);
            return dbEntry;
        }
        //Thêm một đối tượng
        public int? Insert(House model)
        {
            House dbEntry = context.Houses.Find(model.HouseID);
            if (dbEntry != null)
            {
                return null;
            }

            context.Houses.Add(model);
            context.SaveChanges();
            return model.HouseID;
        }
        // Sửa dữ liệu
        public int? Update(House model)
        {
            House dbEntry = context.Houses.Find(model.HouseID);
            //   PropertyTypeBanDoc dbEntry = context.PropertyTypeBanDocs.
            //  Where(x => x.PropertyTypeBanDoc1 = model.PropertyTypeBanDoc1).FirstOrDefault();
            if (dbEntry == null)
            {
                return null;
            }

            dbEntry.Avatar = model.Avatar;
            dbEntry.Location = model.Location;
            dbEntry.PropertyType = model.PropertyType;
            dbEntry.C_Status = model.C_Status;
            dbEntry.Area = model.Area;
            dbEntry.Baths = model.Baths;
            dbEntry.Beds = model.Baths;
            dbEntry.Garage = model.Garage;
            dbEntry.PropertyDescription = model.PropertyDescription;
            dbEntry.DateLine = model.DateLine;
            dbEntry.Map = dbEntry.Map;
            dbEntry.HostID = dbEntry.HostID;
            dbEntry.Price = model.Price;
            context.SaveChanges();

            return model.HouseID;
        }
        public int? Delete(int? Ma)
        {
            House dbEntry = context.Houses.Find(Ma);
            if (dbEntry == null)
            {
                return null;
            }
            context.Houses.Remove(dbEntry);

            context.SaveChanges();
            return Ma;
        }
    }
}