using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Producto
    {
        private string CodProducto;

        public string CodProducto1
        {
            get { return CodProducto; }
            set { CodProducto = value; }
        }
        private string Categoria;

        public string Categoria1
        {
            get { return Categoria; }
            set { Categoria = value; }
        }
        private string Color;

        public string Color1
        {
            get { return Color; }
            set { Color = value; }
        }
        private string Descripcion;

        public string Descripcion1
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        private decimal Precio;

        public decimal Precio1
        {
            get { return Precio; }
            set { Precio = value; }
        }
    }
}
