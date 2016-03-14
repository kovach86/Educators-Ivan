using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Domains.BaseClass;

namespace Domains.Mappers
{
    class MappedState:ClassMap<State>
    {
        public MappedState()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Cities).KeyColumns.Add("StateId");
        }
    }

    class MappedCity : ClassMap<City>
    {
        public MappedCity()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.State).Column("StateId");
        }
    }
}
