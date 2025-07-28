using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversidadLosPatitos.Abstracciones.ModelosUI;

namespace UniversidadLosPatitos.Abstracciones.AccesoADatos.ListarCursos
{
    public interface IListarCursosAD
    {
        Task<List<CursosDto>> Listar();
    }
}
