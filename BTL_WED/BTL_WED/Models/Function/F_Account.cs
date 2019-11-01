using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BTL_WED.Models.Emty;
namespace BTL_WED.Models.Function
{
    public class F_Accout
    {
        private MyDBContext context;
        public F_Accout()
        {
            context = new MyDBContext();
        }
        //Trả về tất cả các bản ghi
        public IQueryable<Accout> DS_Accout
        {
            get { return context.Accouts; }
        }
        //Trả về một đối tượng khi biết khóa
        public Accout FindEntity(string Ma)
        {
            Accout dbEntry = context.Accouts.FirstOrDefault(user => user.UserName == Ma);
            return dbEntry;
        }
        //Thêm một đối tượng
        public string Insert(Accout model)
        {
            Accout dbEntry = context.Accouts.FirstOrDefault(user => user.UserName == model.UserName);
            if (dbEntry != null)
            {
                return null;
            }

            context.Accouts.Add(model);
            context.SaveChanges();
            return model.UserName;
        }
        // Sửa dữ liệu
        public string Update(Accout model)
        {
            Accout dbEntry = context.Accouts.FirstOrDefault(user => user.UserName == model.UserName);
            //   LoaiBanDoc dbEntry = context.LoaiBanDocs.
            //  Where(x => x.LoaiBanDoc1 = model.LoaiBanDoc1).FirstOrDefault();
            if (dbEntry == null)
            {
                return null;
            }
            dbEntry.UserName = model.UserName;
            dbEntry.Pass = model.Pass;
            context.SaveChanges();

            return model.UserName;
        }
        public string Delete(string Ma)
        {
            Accout dbEntry = context.Accouts.Find(Ma);
            if (dbEntry == null)
            {
                return null;
            }
            context.Accouts.Remove(dbEntry);

            context.SaveChanges();
            return Ma;
        }
    }
}