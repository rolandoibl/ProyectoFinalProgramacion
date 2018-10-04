using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materiales
{
    public class Madera : Material
    {
        private float espesor;
        public Madera(string nombre, float densidad, string tipo, float espesor) : base(nombre, densidad, tipo)
        {
            this.Tipo = "Madera";
        }

        public float Espesor { get => espesor; set => espesor = value; }
    }
}
