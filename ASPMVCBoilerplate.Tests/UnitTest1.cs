using System;
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
    }
}
