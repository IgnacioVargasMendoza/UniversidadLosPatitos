using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadLosPatitos.Abstracciones.ModelosUI
{
    public class CursosDto
    {
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El código del curso es requerido.")]
        [StringLength(7, ErrorMessage = "El código del curso no puede superar los 7 caracteres.")]
        [Display(Name = "Código del Curso")]
        public string CodigoDelCurso { get; set; }

        [Required(ErrorMessage = "El nombre del curso es requerido.")]
        [StringLength(30, ErrorMessage = "El nombre del curso no puede superar los 30 caracteres.")]
        [Display(Name = "Nombre del Curso")]
        public string NombreCurso { get; set; }

        [Required(ErrorMessage = "El nombre de la carrera es requerida.")]
        [StringLength(30, ErrorMessage = "El nombre de la carrera no puede superar los 30 caracteres.")]
        [Display(Name = "Carrera")]
        public string Carrera { get; set; }

        [Required(ErrorMessage = "El código del grupo es requerido.")]
        [Display(Name = "Código del Grupo")]
        public string CodigoDelGrupo { get; set; }

        [Required(ErrorMessage = "La cantidad de estudiantes es requerida.")]
        [MinLength(0, ErrorMessage = "La cantidad de estudiantes debe ser mayor a 0.")]
        [Display(Name = "Cantidad de estudiantes permitidos")]
        public int CantidadEstudiantesPermitidos { get; set; }

        [Display(Name = "Cantidad de Estudiantes Matriculados")]
        public int CantidadEstudiantesMatriculados { get; set; }

        [Required(ErrorMessage = "El tipo de modalidad es requerida.")]
        [Display(Name = "Modalidad")]
        public string Modalidad { get; set; }

        [Required(ErrorMessage = "El Profesor es requerido.")]
        [Display(Name = "Profesor")]
        public string Profesor { get; set; }

        [Required(ErrorMessage = "El C2uatrimestre es requerido.")]
        [Display(Name = "Cuatrimestre")]
        public int Cuatrimestre { get; set; }

        [Required(ErrorMessage = "El Dia del Curso es requerido.")]
        [RegularExpression("^(L|K|M|J|V|S)$", ErrorMessage = "El día del curso debe ser 'L' (Lunes), 'K' (Martes), 'M' (Miércoles) 'J' (Jueves), 'V' (Viernes), 'S' (Sábado).")] 
        [Display(Name = "Dia Del Curso")]
        public string DiaDelCurso { get; set; }

        [Required(ErrorMessage = "El Horario es requerido.")]
        [RegularExpression("^(M|T)$", ErrorMessage = "El horario debe ser 'M' (Mañana), 'T' (Tarde)")]
        [Display(Name = "Horario")]
        public string Horario { get; set; }

        [Display(Name = "Fecha de Registro")]
        public DateTime FechaDeRegistro { get; set; }

        [Display(Name = "Fecha de Modificación")]
        public DateTime FechaDeModificacion { get; set; }

        [Display(Name = "Estado")]
        public bool Estado { get; set; }
    }
}
