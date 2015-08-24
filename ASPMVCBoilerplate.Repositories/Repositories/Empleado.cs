using ASPMVCBoilerplate.Entities;
using ASPMVCBoilerplate.Repositories.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPMVCBoilerplate.Repositories
{
    public interface IEmpleadoRepository : IGenericRepository<Entities.Empleado>
    { }

    public class EmpleadoRepository : GenericRepository<Entities.Empleado>, IEmpleadoRepository
    {
        public EmpleadoRepository(ApplicationContext context) : base(context) { }
    }
}
