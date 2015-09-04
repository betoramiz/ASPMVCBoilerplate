using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPMVCBoilerplate.Entities;

namespace ASPMVCBoilerplate.Services
{
    public interface IEmpleadoService
    {
        List<Empleado> GetAll();
    }
}
