using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversidadLosPatitos.Abstracciones.AccesoADatos.Cursos.RegistrarCursos;
using UniversidadLosPatitos.Abstracciones.AccesoADatos.ListarCursos;
using UniversidadLosPatitos.Abstracciones.ModelosUI;
using UniversidadLosPatitos.AccesoADatos.Cursos.ListarCursos;
using UniversidadLosPatitos.AccesoADatos.Cursos.RegistrarCursos;
using UniversidadLosPatitos.AccesoADatos.Modelos;

namespace UniversidadLosPatitos.LogicaDeNegocios.Cursos.RegistrarCursos
{
    public class RegistrarCursosLN : IRegistrarCursosLN
    {
        private readonly IRegistrarCursosAD _registrarCursosAD;
        private readonly IListarCursosAD _listarCursosAD;

        public RegistrarCursosLN()
        {
            _registrarCursosAD = new RegistrarCursosAD();
            _listarCursosAD = new ListarCursosAD();
        }

        public async Task<int> GuardarCurso(CursosDto cursoAGuardar)
        {
            List<CursosDto> listaCursos = await _listarCursosAD.Listar();
            if (listaCursos.Any(cursoEnBaseDatos =>
                cursoEnBaseDatos.Profesor
                    .Equals(cursoAGuardar.Profesor, StringComparison.OrdinalIgnoreCase)
               && cursoEnBaseDatos.DiaDelCurso
                    .Equals(cursoAGuardar.DiaDelCurso, StringComparison.OrdinalIgnoreCase)
               && cursoEnBaseDatos.Horario
                    .Equals(cursoAGuardar.Horario, StringComparison.OrdinalIgnoreCase)
                    )
               )
            {
                throw new Exception("Horarios llenos! Verifique la lista de cursos e intente nuevamente");
            }

            int resultadoRegistroCurso = await _registrarCursosAD.Guardar(cursoAGuardar);

            return resultadoRegistroCurso;

        }
    }
}
