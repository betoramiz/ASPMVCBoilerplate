using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASPMVCBoilerplate.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateUser()
        {
            var empleadoRepository = new Repositories.EmpleadoRepository(new Entities.ApplicationContext());
            var empleado = empleadoRepository.Create(new Entities.Empleado() { Name = "Jose", LastName = "Jose", Birthdate = DateTime.Today, Salary = 1500 });

            Assert.IsTrue(empleado != 0);
        }

        [TestMethod]
        public void GetBy()
        {
            var empleadoRepository = new Repositories.EmpleadoRepository(new Entities.ApplicationContext());
            var todos = empleadoRepository.GetBy(x => x.Salary > 10);

            Assert.IsTrue(todos.Count() > 0);
        }

        [TestMethod]
        public void GetByBirthDate()
        {
            Services.EmpleadoService empleado = new Services.EmpleadoService();
            empleado.GetAll();
        }

        public void IndexController()
        {
            var container = ASPMVCBoilerplate.App_Start.UnityConfig.GetConfiguredContainer();

            Services.IEmpleadoService empleadoService = container.Resolve<Services.IEmpleadoService>();
            ASPMVCBoilerplate.Controllers.EmpleadoController controller = new Controllers.EmpleadoController(empleadoService);

        }
    }
}
