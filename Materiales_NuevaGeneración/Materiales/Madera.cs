using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materiales
{
    public class Madera : Material
    {
 
        public Madera(string nombre, float densidad, string tipo,string medidas) : base(nombre, densidad, tipo,medidas)
        {
        }

    }
}
