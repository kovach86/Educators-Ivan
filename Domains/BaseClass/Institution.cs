using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.BaseClass
{
    public class Institution
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Image { get; set; }
        public virtual int Link { get; set; }
        public virtual int UserId { get; set; }
        public virtual string StateCity { get; set; }

        public virtual IList<Event> Events { get; set; }

    }
}
