using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Domains.BaseClass;

namespace Domains.Mappers
{
    class MappedFieldsOfStudy:ClassMap<FieldsOfStudy>
    {
        public MappedFieldsOfStudy()
        {
            Id(x => x.Id);
            Map(x => x.FieldName);

            HasManyToMany<Lecturer>(x => x.Lecturers).Table("LecturerForStudy")
           .ParentKeyColumn("FieldOfStudyId").ChildKeyColumn("LecturerId");
        }
    }
}
