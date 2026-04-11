using System;
using System.Collections.Generic;
using System.Text;

namespace appSubastaTrabajo.Modelos
{
    public class Oferta
    {
        public UsuarioDTO Usuario { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
