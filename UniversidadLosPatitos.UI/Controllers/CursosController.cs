using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UniversidadLosPatitos.Abstracciones.LogicaDeNegocios.Cursos.ListarCursos;
using UniversidadLosPatitos.Abstracciones.LogicaDeNegocios.Cursos.RegistrarCursos;
using UniversidadLosPatitos.Abstracciones.ModelosUI;
using UniversidadLosPatitos.LogicaDeNegocios.Cursos.ListarCursos;

namespace UniversidadLosPatitos.UI.Controllers
{
    public class CursosController : Controller
    {
        private readonly IListarCursosLN listarCursosLN;
        private readonly IRegistrarCursosLN registrarCursosLN;

        public CursosController() { 
            listarCursosLN = new ListarCursosLN();
        }
        // GET: Cursos
        public async Task<ActionResult> ListaCursos()
        {
            List<CursosDto> listaCursos = await listarCursosLN.Listar();
            return View(listaCursos);
        }

        public ActionResult RegistrarCurso()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarCurso(CursosDto cursoAGuardar)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int resultadoRegistroCurso = await registrarCursosLN.GuardarCurso(cursoAGuardar);
                    if (resultadoRegistroCurso > 0)
                    {
                        ViewBag.Mensaje = "Curso registrado exitosamente.";
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error al registrar el curso. Intente nuevamente.";
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.Mensaje = ex.Message;
                }
            }
            return RedirectToAction("ListaCursos");
        }
    }
}