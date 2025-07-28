using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversidadLosPatitos.Abstracciones.AccesoADatos.ListarCursos;
using UniversidadLosPatitos.Abstracciones.ModelosUI;
using UniversidadLosPatitos.AccesoADatos.Contexto;
using UniversidadLosPatitos.AccesoADatos.Modelos;

namespace UniversidadLosPatitos.AccesoADatos.Cursos.ListarCursos
{
    public class ListarCursosAD : IListarCursosAD
    {
        private readonly UniversidadLosPatitosContexto _contexto;

        public ListarCursosAD() { 
            _contexto = new UniversidadLosPatitosContexto();
        }
        public async Task<List<CursosDto>> Listar()
        {

            List <CursosAD> cursosBaseDatos = await Task.Run(() => _contexto.Cursos.ToList());

            List<CursosDto> cursosDto = cursosBaseDatos.Select( curso =>  new CursosDto { 
                Id = curso.Id,
                CodigoDelCurso = curso.CodigoDelCurso,
                NombreCurso = curso.NombreCurso,
                Carrera = curso.Carrera,
                CodigoDelGrupo = curso.CodigoDelGrupo,
                CantidadEstudiantesPermitidos = curso.CantidadEstudiantesPermitidos,
                CantidadEstudiantesMatriculados = curso.CantidadEstudiantesMatriculados,
                Modalidad = curso.Modalidad,
                Profesor = curso.Profesor,
                Cuatrimestre = curso.Cuatrimestre,
                DiaDelCurso = curso.DiaDelCurso,
                Horario = curso.Horario,
                FechaDeRegistro = curso.FechaDeRegistro,
            }).ToList();

            return cursosDto;

        }
    }
}
