using Domains;
using TextHandlers;
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
            using (_session = sessionFactory.OpenSession())
            {
                try
                {
                    _session.SaveOrUpdate(entity);
                    return "ok";
                }
                catch (Exception ex)
                {
                    ErrorLogger.WriteError(ex);
                    return "error";
                }
            }
        }

        public string Delete(T entity)
        {
            using (_session = sessionFactory.OpenSession())
            {
                try
                {
                    _session.Delete(entity);
                    return "ok";
                }
                catch (Exception ex)
                {
                    ErrorLogger.WriteError(ex);
                    return "error";
                }
            }
        }

        public T FindById(int id)
        {
            using (_session = sessionFactory.OpenSession())
            {
                try
                {
                    return _session.Get<T>(id);
                }
                catch (Exception ex)
                {
                    ErrorLogger.WriteError(ex);
                    return null;
                }
            }
        }
        
    }
}
