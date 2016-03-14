using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.BaseClass
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual string Email { get; set; }
        public virtual bool? Admin { get; set; }
        public virtual bool? Institution { get; set; }
        public virtual bool? Lecturer { get; set; }
    }
}
