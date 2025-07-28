using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadLosPatitos.AccesoADatos.Modelos
{
    [Table("CURSOS")]
    public class CursosAD
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("CodigoDelCurso")]
        public string CodigoDelCurso { get; set; }

        [Column("NombreDelCurso")]
        public string NombreCurso { get; set; }

        [Column("Carrera")]
        public string Carrera { get; set; }

        [Column("CodigoDelGrupo")]
        public string CodigoDelGrupo { get; set; }

        [Column("CantidadEstudiantesPermitidos")]
        public int CantidadEstudiantesPermitidos { get; set; }

        [Column("CantidadEstudiantesMatriculados")]
        public int CantidadEstudiantesMatriculados { get; set; }

        [Column("Modalidad")]
        public string Modalidad { get; set; }

        [Column("Profesor")]
        public string Profesor { get; set; }

        [Column("Cuatrimestre")]
        public int Cuatrimestre { get; set; }

        [Column("DiaDelCurso")]
        public string DiaDelCurso { get; set; }

        [Column("Horario")]
        public string Horario { get; set; }

        [Column("FechaDeRegistro")]
        public DateTime FechaDeRegistro { get; set; }

        [Column("FechaDeModificacion")]
        public DateTime? FechaDeModificacion { get; set; }

        [Column("Estado")]
        public bool Estado { get; set; }
    }
}
