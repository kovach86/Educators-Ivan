using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains.BaseClass;
using Domains;

namespace Repositories.ClassBasedRepositories
{
    public class UsersRepository : BaseRepository<User>,IUsersRepository
    {

        public  User FindBy(string username, string password, string email)
        {
            using (_session=sessionFactory.OpenSession())
            {
                
                var result = _session.CreateQuery("Select u from User u WHERE u.Username=:username").
                    SetParameter("username", username).List<User>();
                
                    return result.FirstOrDefault();
            }
        }
    }

    public interface IUsersRepository:IBaseRepository<User>
        { 
        User FindBy(string username,string password,string email);
    }
}
