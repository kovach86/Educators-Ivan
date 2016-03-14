using Domains.BaseClass;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Mappers
{
     class MappedUser:ClassMap<User>
    {
        public MappedUser()
        {
            Id(x => x.Id);
            Map(x => x.Username);
            Map(x => x.Password);
            Map(x => x.Email);
            Map(x => x.Admin);
            Map(x => x.Institution);
            Map(x => x.Lecturer);
        }
    }
}
