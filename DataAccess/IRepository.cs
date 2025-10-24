using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBiding.DataAccess
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        // T GetById(int id);
        // int DeleteById(int id);
        // int Insert(T entity);
        // int Update(T entity);
    }
}
