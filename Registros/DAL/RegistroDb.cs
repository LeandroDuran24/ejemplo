using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Registros.Entidades;

namespace Registros.DAL
{
    public class RegistroDb:DbContext
    {
        public RegistroDb():base("ConStr")
        {
                
        }
        public DbSet<PeliculaEntidad> peli { get; set; }
    }
}
