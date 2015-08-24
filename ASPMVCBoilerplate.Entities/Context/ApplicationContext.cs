using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ASPMVCBoilerplate.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("name=ApplicationContext") { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
