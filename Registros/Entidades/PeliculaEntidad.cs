using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Registros.Entidades
{
    public class PeliculaEntidad
    {
        [Key]
        public int PeliculaId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
    }
}
