using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversidadLosPatitos.Abstracciones.ModelosUI;

namespace UniversidadLosPatitos.Abstracciones.AccesoADatos.Cursos.RegistrarCursos
{
    public interface IRegistrarCursosAD
    {
        Task<int> Guardar(CursosDto cursoAGuardar);
    }
}
