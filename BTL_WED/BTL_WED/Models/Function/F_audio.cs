using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BTL_WED.Models.Emty;
namespace BTL_WED.Models.Function
{
    public class F_Audio
    {
        private MyDBContext context;
        public F_Audio()
        {
            context = new MyDBContext();
        }
        //Trả về tất cả các bản ghi
        public IQueryable<Audio> DS_Audio
        {
            get { return context.Audios; }
        }
        //Trả về một đối tượng khi biết khóa
        public Audio FindEntity(int? Ma)
        {
            Audio dbEntry = context.Audios.Find(Ma);
            return dbEntry;
        }
        //Thêm một đối tượng
        public int? Insert(Audio model)
        {
            Audio dbEntry = context.Audios.Find(model.AudioID);
            if (dbEntry != null)
            {
                return null;
            }

            context.Audios.Add(model);
            context.SaveChanges();
            return model.AudioID;
        }
        // Sửa dữ liệu
        public int? Update(Audio model)
        {
            Audio dbEntry = context.Audios.Find(model.AudioID);
            //   LoaiBanDoc dbEntry = context.LoaiBanDocs.
            //  Where(x => x.LoaiBanDoc1 = model.LoaiBanDoc1).FirstOrDefault();
            if (dbEntry == null)
            {
                return null;
            }
            dbEntry.HouseID = model.HouseID;
            dbEntry.URL = model.URL;
            context.SaveChanges();

            return model.AudioID;
        }
        public int? Delete(int? Ma)
        {
            Audio dbEntry = context.Audios.Find(Ma);
            if (dbEntry == null)
            {
                return null;
            }
            context.Audios.Remove(dbEntry);

            context.SaveChanges();
            return Ma;
        }
    }
}