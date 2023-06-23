using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital.Controllers
{
    public class Hospital : Controller
    {
        // GET: Hospital
        public ActionResult GetAll()
        {
            ML.Paciente paciente = new ML.Paciente();
            ML.Result result = BL.Paciente.GetAll();
            if (result.Correct)
            {
                paciente.Pacientes = result.Objects;
            }
            return View(paciente);
        }
    }
}