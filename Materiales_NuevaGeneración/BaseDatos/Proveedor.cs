using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class Proveedor
    {
        private string nombre;
        private float precio;
        private int stock;

        public Proveedor(string nombre, float precio, int stock)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
