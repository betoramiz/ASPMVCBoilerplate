using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCBoilerplate.Services;

namespace ASPMVCBoilerplate.Controllers
{
    public class EmpleadoController : Controller
    {
        private IEmpleadoService empleadoService;
        public EmpleadoController(IEmpleadoService empleadoService)
        {
            this.empleadoService = empleadoService;
        }

        public ActionResult Index()
        {
            var empleados = empleadoService.GetAll();
            return View();
        }
    }
}