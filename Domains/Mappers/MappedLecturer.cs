using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains.BaseClass;
using FluentNHibernate.Mapping;

namespace Domains.Mappers
{
     class MappedLecturer:ClassMap<Lecturer>
    {
        public MappedLecturer()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Surname);
            Map(x => x.Email);
            Map(x => x.Image);
            Map(x => x.Specialty);
            Map(x => x.UserId);

            HasMany(x => x.ListOfLegacyEvents).KeyColumns.Add("LecturerId");

            HasManyToMany<FieldsOfStudy>(x => x.ListOfStudies).Table("LecturerForStudy")
                .ParentKeyColumn("LecturerId").ChildKeyColumn("FieldOfStudyId");
        }
    }

    class MappedLecturerForStudy : ClassMap<LecturerForStudy>
    {
        public MappedLecturerForStudy()
        {
            Id(x => x.Id);
        }
    }

    class MappedLegacyEvent : ClassMap<LegacyEvent>
    {
        public MappedLegacyEvent()
        {
            Id(x => x.Id);
            Map(x => x.Description);
            References(x => x.Lecturer).Column("LecturerId");
        }
    }
}
