using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Cliente
    {
        private string DNI;

        public string DNI1
        {
            get { return DNI; }
            set { DNI = value; }
        }
        private string Apellido;

        public string Apellido1
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        private string Nombre;

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string Direccion;

        public string Direccion1
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
    }
}
