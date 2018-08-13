using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.DataAccessLayer.EntityFramework
{
    public class Initializer:CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            base.Seed(context);
        }
    }
}
