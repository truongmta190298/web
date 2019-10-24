using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BTL_WED.Models.Emty;
namespace BTL_WED.Models.Function
{
    public class F_Host
    {
        private MyDBContext context;
        public F_Host()
        {
            context = new MyDBContext();
        }
        //Trả về tất cả các bản ghi
        public IQueryable<Host> DS_Host
        {
            get { return context.Hosts; }
        }
        //Trả về một đối tượng khi biết khóa
        public Host FindEntity(int? Ma)
        {
            Host dbEntry = context.Hosts.Find(Ma);
            return dbEntry;
        }
        //Thêm một đối tượng
        public int? Insert(Host model)
        {
            Host dbEntry = context.Hosts.Find(model.HostID);
            if (dbEntry != null)
            {
                return null;
            }

            context.Hosts.Add(model);
            context.SaveChanges();
            return model.HostID;
        }
        // Sửa dữ liệu
        public int? Update(Host model)
        {
            Host dbEntry = context.Hosts.Find(model.HostID);
            //   LoaiBanDoc dbEntry = context.LoaiBanDocs.
            //  Where(x => x.LoaiBanDoc1 = model.LoaiBanDoc1).FirstOrDefault();
            if (dbEntry == null)
            {
                return null;
            }
            dbEntry.HostName = model.HostName;
            dbEntry.Address = model.Address;
            dbEntry.Email = model.Email;
            dbEntry.PhoneNumber = model.PhoneNumber;
            dbEntry.Avatar = model.Avatar;
            context.SaveChanges();

            return model.HostID;
        }
        public int? Delete(int? Ma)
        {
            Host dbEntry = context.Hosts.Find(Ma);
            if (dbEntry == null)
            {
                return null;
            }
            context.Hosts.Remove(dbEntry);

            context.SaveChanges();
            return Ma;
        }
    }
}