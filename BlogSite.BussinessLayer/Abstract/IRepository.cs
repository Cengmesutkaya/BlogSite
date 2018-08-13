using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.BussinessLayer.Abstract
{
    public interface IRepository<T>
    {
        List < T> List();
        int Save();
        int Insert(T obj);
        int Update(T obj);
        int Delete(T obj);
        T GeyById(int Id);
    }
}
