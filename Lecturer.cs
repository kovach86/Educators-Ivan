using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.BaseClass
{
    public class Lecturer
    {
        public virtual int Id { get; set; }
        public virtual string  Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string  Email { get; set; }
        public virtual string Image { get; set; }
        public virtual string Specialty { get; set; }
        public virtual int UserId { get; set; }
        public virtual string StateCity { get; set; }
        public virtual IList<LegacyEvent> ListOfLegacyEvents { get; set; }
        public virtual IList<FieldsOfStudy> ListOfStudies { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }

    public class LecturerForStudy
    {
        public virtual int Id { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public virtual FieldsOfStudy StudyField { get; set; }
    }

    public class LegacyEvent
    {
        public virtual int Id { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public virtual string Description { get; set; }
    }
}

