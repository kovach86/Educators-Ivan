using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using System.IO;

namespace Repositories
{
    public class BaseRepository<T>:NHibernateBase,IBaseRepository<T> where T :class
    {
        protected ISession _session;

        public IList<T> GetAll()
        {
            using (_session = sessionFactory.OpenSession())
            {
                return _session.CreateCriteria(typeof(T)).List<T>();
            }
        }

        public virtual string Add(T entity)
        {
            using (_session=sessionFactory.OpenSession())
            {
                try
                {
                    _session.Save(entity);
                    return "ok";
                }
                catch (Exception ex)
                {
                    ErrorLogger.WriteError(ex);
                    return "error";
                }
            }
        }

        public string Update(T entity)
        {
            throw new NotImplementedException();
        }

        public string Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T FindById(int id)
        {
            throw new NotImplementedException();
        }
        
    }
}
