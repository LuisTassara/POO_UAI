﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_de_Canchas_2._0
{
   public class Cancha6
    {
        public Cancha6(string descripcion, int precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
    }
}
