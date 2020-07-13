using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recital

{
  // enum TipoEntrada { Campo = 100, CampoVip = 125, PlateaCentral = 75, PlateaLateral = 50 };


    
    public class Entrada
    {
        public Entrada(string tipo, int precio)

        {
            Tipo = tipo;
            Precio = precio;
            //Banda = new Banda();

        }
        public Entrada(Banda banda)
        {
            Banda = banda;


        }
        public Banda Banda { get; set; }

        public int Precio { get; set; }
        public string Tipo { get; set; }
      // public Banda Banda { get; set; }

      
        

    }


    
}

    
            

       
