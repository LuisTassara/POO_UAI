using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_de_Canchas_2._0
{
    public class Predio
    {
        public Predio()
        {
            Turnos = new List<Turno>();
            RecaudacionC5 = new List<Cancha5>();
            RecaudacionC6 = new List<Cancha6>();
            RecaudacionC7 = new List<Cancha7>();



        }

        public List<Turno> Turnos { get; set; }
        public List<Cancha5>RecaudacionC5{ get; set; }
        public List<Cancha6> RecaudacionC6 { get; set; }
        public List<Cancha7> RecaudacionC7{ get; set; }

        public void Reserva ( Turno turno)
        {
                
            if (turno.Hora_fin >=)

        }
    }
    

}
