using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos
{
    class Cliente
    {
        public string? Id { get; set; }
        private string? nombre;
        private string? apellido;
        private string? telefono;
        private string? tarjetaCredito;


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string TarjetaCredito
        {
            get { return tarjetaCredito; }
            set { tarjetaCredito = value; }
        }

        public string DatosCompletos
        {
            get { return Nombre + " " + Apellido + " " + Telefono + " " + TarjetaCredito; }
        }

        public override string ToString()
        {
            return DatosCompletos;
        }

    }
}
