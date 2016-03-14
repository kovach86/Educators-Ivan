using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class NHibernateBase
    {
        protected readonly ISessionFactory sessionFactory;
        protected ISession _session;

        public NHibernateBase()
        {
            //string connection_string = ConfigurationManager.ConnectionStrings["Connection_String"].ConnectionString;
            string connection_string = @"Server=localhost;Database=Education;Uid=root;";
            sessionFactory = Fluently.Configure()
            .Database(MySQLConfiguration.Standard
            .ConnectionString(connection_string))
            .Mappings(m => m.FluentMappings.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly()).Conventions.Add(FluentNHibernate.Conventions.Helpers.DefaultLazy.Never()))
            .BuildSessionFactory();
        }
    }
}
