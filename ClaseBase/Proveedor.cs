using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Proveedor
    {
        private string CUIT;

        public string CUIT1
        {
            get { return CUIT; }
            set { CUIT = value; }
        }
        private string RazonSocial;

        public string RazonSocial1
        {
            get { return RazonSocial; }
            set { RazonSocial = value; }
        }
        private string Domicilio;

        public string Domicilio1
        {
            get { return Domicilio; }
            set { Domicilio = value; }
        }
        private string Telefono;

        public string Telefono1
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
    }
}
