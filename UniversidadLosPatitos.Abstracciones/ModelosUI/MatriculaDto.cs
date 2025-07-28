using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace UniversidadLosPatitos.Abstracciones.ModelosUI
{
    public class MatriculaDto
    {
        public int Id { get; set; }

        public string Estudiante { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string Identificacion { get; set; }

        public string carnet { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Direccion { get; set; }

        public int IdCurso { get; set; }

        public DateTime FechaDeRegistro { get; set; }
    }
}
