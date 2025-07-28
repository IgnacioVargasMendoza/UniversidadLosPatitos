using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using UniversidadLosPatitos.Abstracciones.AccesoADatos.ListarCursos;
using UniversidadLosPatitos.Abstracciones.LogicaDeNegocios.Cursos.ListarCursos;
using UniversidadLosPatitos.Abstracciones.ModelosUI;
using UniversidadLosPatitos.AccesoADatos.Cursos.ListarCursos;
using UniversidadLosPatitos.AccesoADatos.Modelos;

namespace UniversidadLosPatitos.LogicaDeNegocios.Cursos.ListarCursos
{
    public class ListarCursosLN : IListarCursosLN
    {
        private readonly IListarCursosAD _listarCursosAD;

        public ListarCursosLN() {
            _listarCursosAD = new ListarCursosAD();
        }

        public async Task<List<CursosDto>> Listar()
        {
            List<CursosDto> listaCursosDto = await _listarCursosAD.Listar();
            return listaCursosDto;
        }
 

    }
}
