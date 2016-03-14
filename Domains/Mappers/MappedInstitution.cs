using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains.BaseClass;
using FluentNHibernate.Mapping;

namespace Domains.Mappers
{
    class MappedInstitution:ClassMap<Institution>
    {
        public MappedInstitution()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Image);
            Map(x => x.Link);
            Map(x => x.UserId);
            Map(x => x.StateCity);

            HasMany(x => x.Events).KeyColumns.Add("InstitutionId");
        }
    }
}
