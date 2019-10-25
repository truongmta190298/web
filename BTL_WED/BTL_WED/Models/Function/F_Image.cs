using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BTL_WED.Models.Emty;
namespace BTL_WED.Models.Function
{
    public class F_Image
    {
        private MyDBContext context;
        public F_Image()
        {
            context = new MyDBContext();
        }
        //Trả về tất cả các bản ghi
        public IQueryable<Image> DS_Image
        {
            get { return context.Images; }
        }
        //Trả về một đối tượng khi biết khóa
        public Image FindEntity(int? Ma)
        {
            Image dbEntry = context.Images.Find(Ma);
            return dbEntry;
        }
        //Trả về list ảnh theo mã nhà
        public List<Image> GetImageHouse(int? HouseID)
        {
            var list =
            (
                 from b in context.Images
                 where b.HouseID == HouseID
                 select b).ToList();
            return list;
        }
        //Thêm một đối tượng
        public int? Insert(Image model)
        {
            Image dbEntry = context.Images.Find(model.ImageID);
            if (dbEntry != null)
            {
                return null;
            }

            context.Images.Add(model);
            context.SaveChanges();
            return model.ImageID;
        }
        // Sửa dữ liệu
        public int? Update(Image model)
        {
            Image dbEntry = context.Images.Find(model.ImageID);
            //   LoaiBanDoc dbEntry = context.LoaiBanDocs.
            //  Where(x => x.LoaiBanDoc1 = model.LoaiBanDoc1).FirstOrDefault();
            if (dbEntry == null)
            {
                return null;
            }
            dbEntry.HouseID = model.HouseID;
            dbEntry.URL = model.URL;
            context.SaveChanges();

            return model.ImageID;
        }
        public int? Delete(int? Ma)
        {
            Image dbEntry = context.Images.Find(Ma);
            if (dbEntry == null)
            {
                return null;
            }
            context.Images.Remove(dbEntry);

            context.SaveChanges();
            return Ma;
        }
    }
}