using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Materiales;

namespace BaseDatos
{
    public class Almacen
    {
        ArrayList a = new ArrayList();

        Metal acero = new Metal("Acero 1080-OQT700", 8736.2f, "Metal","3mm", 18.9f, 91.6f);
        Metal aluminio = new Metal("Aluminio 1100-H12", 8736.2f, "Metal","8mm",123.7f,91.4f);
        Metal cobre = new Metal("Cobre C14500", 8736.2f, "Metal","7mm", 77.6f, 34.7f);

        Madera balsa = new Madera("Madera balsa", 800.5f, "Madera","2mm");
        Madera pino = new Madera("Pino", 1200.4f, "Madera","2mm");
 

    }
}
