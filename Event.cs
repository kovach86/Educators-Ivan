using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.BaseClass
{
    public class Event
    {
        public virtual int  Id { get; set; }
        public virtual string EventName { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual DateTime DateTime { get; set; }
        public virtual string  Language { get; set; }


    }
}
