using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recital
{
    public class Predio
    {

        public Predio()
        {
           // EntradasVendidas = new List<Entrada>();
            Fechas = new List<Banda>();
            Bandas = new List<Banda>();
            Entradas = new List<Entrada>();
            Entradasvendidas = new List<Entrada>();
            EntradasLaRenga = new List<Entrada>();
            EntradasMetallica = new List<Entrada>();





            var larenga = new Banda("LaRenga");
            var metallica = new Banda("Metallica");

            var fecha1 = new Banda(DateTime.Now.AddDays(5));
            var fecha2 = new Banda(DateTime.Now.AddDays(7));

            var entrada1 = new Entrada("Campo", 5);
            var entrada2 = new Entrada("Campo-VIP", 10);
            var entrada3 = new Entrada("Platea-Central", 15);
            var entrada4 = new Entrada("Platea-Lateral", 20);

            Entradas.Add(entrada1);
            Entradas.Add(entrada2);
            Entradas.Add(entrada3);
            Entradas.Add(entrada4);




            Bandas.Add(larenga);
            Bandas.Add(metallica);

            Fechas.Add(fecha1);
            Fechas.Add(fecha2);


            //Entradas.Add(entrada1);
            

        }   
       
        public List<Banda> Fechas { get; set; }
        public List<Banda> Bandas { get; set; }
        public List<Entrada> Entradas { get; set; }
        public List<Entrada> Entradasvendidas { get; set; }
        public List <Entrada> EntradasLaRenga { get; set; }
        public List<Entrada> EntradasMetallica { get; set; }


        //   private Entrada precio;

        // public List<Entrada> EntradasVendidas { get; set; }

        public void Comprar(Entrada entrada, Banda banda, Banda fecha)
        {
            Entradasvendidas.Add(entrada);
           if (banda.Nombre == "LaRenga" )

            {
                EntradasLaRenga.Add(entrada);

            }
            else
            {
                EntradasMetallica.Add(entrada);
            }

            
            

        }

        

        public double TotalRecaudado()
        {
            return Entradasvendidas.Sum(ev => ev.Precio);
        }
        public double CantidadEntradasVendidas()
        {
            return Entradasvendidas.Count();
        }
        public double CantidadEntradasLaRenga()
        {
            return EntradasLaRenga.Sum(cevlr => cevlr.Precio);

        }
        public double CantidadEntradasMetallica()
        {
            return EntradasMetallica.Sum(cevm => cevm.Precio);

        }

    }
}
