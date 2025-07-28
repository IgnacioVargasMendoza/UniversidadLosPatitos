using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UniversidadLosPatitos.Abstracciones.LogicaDeNegocios.Cursos.ListarCursos;
using UniversidadLosPatitos.Abstracciones.ModelosUI;
using UniversidadLosPatitos.LogicaDeNegocios.Cursos.ListarCursos;

namespace UniversidadLosPatitos.UI.Controllers
{
    public class CursosController : Controller
    {
        private readonly IListarCursosLN listarCursosLN;

        public CursosController() { 
            listarCursosLN = new ListarCursosLN();
        }
        // GET: Cursos
        public async Task<ActionResult> ListaCursos()
        {
            List<CursosDto> listaCursos = await listarCursosLN.Listar();
            return View(listaCursos);
        }
    }
}