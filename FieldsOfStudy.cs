using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.BaseClass
{
    public class FieldsOfStudy
    {
        public virtual int Id { get; set; }
        public virtual IList<Lecturer> Lecturers { get; set; }
        public virtual string FieldName { get; set; }

    }

  

}
