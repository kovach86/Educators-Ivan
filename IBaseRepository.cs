using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBaseRepository<TEntity> where TEntity:class
    {
        #region CRUD and oher basic operations
        IList<TEntity> GetAll();
        string Add(TEntity entity);
        string Update(TEntity entity);
        string Delete(TEntity entity);
        TEntity FindById(int id);
        #endregion
       
    }
}
