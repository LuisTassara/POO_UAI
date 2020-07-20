using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_de_Canchas_2._0
{
   public class Turno
    {
        public Turno(DateTime hora_ini, DateTime hora_fin)
        {
            Hora_ini = hora_ini;
            Hora_fin = hora_fin;
        }
        public DateTime Hora_ini { get; set; }
        public DateTime Hora_fin { get; set; }

        public bool Reserva()
        {
            if (DateTime.Now < Hora_ini)
                return false;

            else

                return true;

        }
    }
}
