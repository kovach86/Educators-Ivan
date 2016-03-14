using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains.BaseClass;
using FluentNHibernate.Mapping;

namespace Domains.Mappers
{
    class MappedEvent:ClassMap<Event>
    {
        public MappedEvent()
        {
            Id(x => x.Id);
         
        }
    }
}
