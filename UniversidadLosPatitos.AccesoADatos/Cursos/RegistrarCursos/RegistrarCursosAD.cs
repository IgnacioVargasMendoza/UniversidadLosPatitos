using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversidadLosPatitos.Abstracciones.AccesoADatos.Cursos.RegistrarCursos;
using UniversidadLosPatitos.Abstracciones.ModelosUI;
using UniversidadLosPatitos.AccesoADatos.Contexto;
using UniversidadLosPatitos.AccesoADatos.Modelos;

namespace UniversidadLosPatitos.AccesoADatos.Cursos.RegistrarCursos
{
    public class RegistrarCursosAD: IRegistrarCursosAD
    {
        private readonly UniversidadLosPatitosContexto _contexto;

        public RegistrarCursosAD()
        {
            _contexto = new UniversidadLosPatitosContexto();
        }

        public async Task<int> Guardar(CursosDto cursoAGuardar)
        {
            CursosAD cursoAGuardarEnBD = ConvertirObjeto(cursoAGuardar);
            _contexto.Cursos.Add(cursoAGuardarEnBD);
            int resultadoRegistroCurso = await _contexto.SaveChangesAsync();
            return resultadoRegistroCurso;
        }

        private CursosAD ConvertirObjeto(CursosDto cursoAGuardar)
        {
            return new CursosAD
            {
                CodigoDelCurso = cursoAGuardar.CodigoDelCurso,
                NombreCurso = cursoAGuardar.NombreCurso,
                Carrera = cursoAGuardar.Carrera,
                CodigoDelGrupo = cursoAGuardar.CodigoDelGrupo,
                CantidadEstudiantesPermitidos = cursoAGuardar.CantidadEstudiantesPermitidos,
                CantidadEstudiantesMatriculados = cursoAGuardar.CantidadEstudiantesMatriculados,
                Modalidad = cursoAGuardar.Modalidad,
                Profesor = cursoAGuardar.Profesor,
                Cuatrimestre = cursoAGuardar.Cuatrimestre,
                DiaDelCurso = cursoAGuardar.DiaDelCurso,
                Horario = cursoAGuardar.Horario,
            };
        }
    }
 }
