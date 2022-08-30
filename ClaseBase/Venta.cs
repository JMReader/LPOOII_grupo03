using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Venta
    {
        private int NroFactura;

        public int NroFactura1
        {
            get { return NroFactura; }
            set { NroFactura = value; }
        }
        private DateTime FechaFactura;

        public DateTime FechaFactura1
        {
            get { return FechaFactura; }
            set { FechaFactura = value; }
        }
        private string Legajo;

        public string Legajo1
        {
            get { return Legajo; }
            set { Legajo = value; }
        }
        private string DNI;

        public string DNI1
        {
            get { return DNI; }
            set { DNI = value; }
        }
        private string CodProducto;

        public string CodProducto1
        {
            get { return CodProducto; }
            set { CodProducto = value; }
        }
        private decimal Precio;

        public decimal Precio1
        {
            get { return Precio; }
            set { Precio = value; }
        }
        private int Cantidad;

        public int Cantidad1
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }
        private decimal Importe;

        public decimal Importe1
        {
            get { return Importe; }
            set { Importe = value; }
        }
    }
}
