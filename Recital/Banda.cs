using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recital
{

    public class Banda
    {

        public Banda(string nombre)
        {
            Nombre = nombre;

        }

        public Banda(DateTime fecha)
        {
            Fecha = fecha;

        }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
    }
    

    

}
