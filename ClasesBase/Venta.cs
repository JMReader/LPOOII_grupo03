﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Venta
    {
        public int NroFactura { get; set; }
        public DateTime FechaFactura { get; set;}
        public string Legajo { get; set;}
        public string DNI { get; set;}
        public string CodProducto { get; set; }
        public decimal Precio { get; set;}
        public int Cantidad { get; set;}
        public decimal Importe { get; set;}

        public Venta()
        { 
        
        }
    }
}
