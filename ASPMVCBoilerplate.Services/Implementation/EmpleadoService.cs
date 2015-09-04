using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPMVCBoilerplate.Entities;
using ASPMVCBoilerplate.Repositories;

namespace ASPMVCBoilerplate.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private EmpleadoRepository empleadoRepository;

        public EmpleadoService()
        {
            empleadoRepository = new EmpleadoRepository(new ApplicationContext());
        }

        public List<Empleado> GetAll()
        {
            return empleadoRepository.GetAll().ToList();
        }
    }
}
