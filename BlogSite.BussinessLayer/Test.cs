using BlogSite.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BussinessLayer
{
    public class Test
    {
        public Test()
        {
            DataContext db = new DataContext();
           // db.Database.Delete();
            db.Database.CreateIfNotExists();
        }
    }
}
