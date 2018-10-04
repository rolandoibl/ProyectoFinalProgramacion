using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Materiales_NuevaGeneración
{
    public partial class Form1 : Form
    {
        Material miCategoria;
        ArrayList categorias;
        ArrayList metales;
        ArrayList maderas;
        ArrayList compuestos;


        public Form1()
        {
            InitializeComponent();
            categorias = new ArrayList();
            categorias.Add("Metales");
            categorias.Add("Maderas");
            categorias.Add("Polímeros");

            metales = new ArrayList();
            metales.Add(new Material("Acero 1080-OQT700", 8736.2f,""));
            metales.Add(new Material("Aluminio 1100-H12", 8736.2f,""));
            metales.Add(new Material("Cobre C14500", 8736.2f,""));

            maderas = new ArrayList();
            maderas.Add(new Material("Pino", 3874.9f,""));
            maderas.Add(new Material("Pino", 3874.9f,""));
            maderas.Add(new Material("Pino", 3874.9f,""));

            compuestos = new ArrayList();
            compuestos.Add(new Material("Fibra de carbono",3847.45f,""));
            compuestos.Add(new Material("Fibra de vidrio", 2837.4f,""));
            compuestos.Add(new Material("Fibra metálica", 2837.4f,""));

        }

        
    }
}
