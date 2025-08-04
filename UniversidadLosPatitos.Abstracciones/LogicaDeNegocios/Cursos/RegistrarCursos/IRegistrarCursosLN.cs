using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversidadLosPatitos.Abstracciones.ModelosUI;

namespace UniversidadLosPatitos.Abstracciones.LogicaDeNegocios.Cursos.RegistrarCursos
{
    public interface IRegistrarCursosLN
    {
        Task<int> GuardarCurso(CursosDto cursoAGuardar);
    }
}
