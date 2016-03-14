using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains.BaseClass;

namespace Repositories.ClassBasedRepositories
{
    public class LecturersRepository : BaseRepository<Lecturer>, ILecturerRepository
    {
        public string Save(Lecturer l)
        {
            using (_session = sessionFactory.OpenSession())
            {
                try
                {
                    _session.SaveOrUpdate(l);
                    return "ok";
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
                
            }

        }
    }

    public interface ILecturerRepository:IBaseRepository<Lecturer>
    {
        string Save(Lecturer l);
    }

}
