using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.BaseClass
{
    public class State
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<City> Cities { get; set; }
    }
    public class City
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual State  State { get; set; }
    }

}
