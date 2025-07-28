using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversidadLosPatitos.AccesoADatos.Modelos;

namespace UniversidadLosPatitos.AccesoADatos.Contexto
{
    public class UniversidadLosPatitosContexto : DbContext
    {
        public UniversidadLosPatitosContexto() : base("name=UniversidadLosPatitosContexto")
        {
            Database.SetInitializer<UniversidadLosPatitosContexto>(null);
        }

        public DbSet<MatriculaAD> Matriculas { get; set; }
        public DbSet<CursosAD> Cursos { get; set; }

    }
}
