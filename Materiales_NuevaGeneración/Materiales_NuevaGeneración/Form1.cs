using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using BaseDatos;
using Materiales;

namespace Materiales_NuevaGeneración
{
    public partial class Form1 : Form
    {
        #region Atributos
        ArrayList almacenMetal;
        ArrayList almacenMadera;
        Metal miMetal;
        Madera miMadera;
        int indiceOpciones;
        Proveedores formProveedores;
        #endregion

        public Form1()
        {
            InitializeComponent();
            almacenMetal = new ArrayList();
            almacenMadera = new ArrayList();



            almacenMetal.Add(new Metal("Acero 1080-OQT700", 999.2f, "Metal","6mm", 18.9f, 91.6f));
            almacenMetal.Add(new Metal("Aluminio 1100-H12", 877.2f, "Metal","6mm", 123.7f, 91.4f));
            almacenMetal.Add(new Metal("Cobre C14500", 456.2f, "Metal","7mm", 77.6f, 34.7f));
            almacenMadera.Add(new Madera("Pino", 1200.4f, "Madera", "2mm"));
            almacenMadera.Add(new Madera("Madera balsa", 800.5f, "Madera", "3mm"));

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOpciones.Enabled = true;
            cmbCategoria.Enabled = false;
            if (cmbCategoria.SelectedIndex == 0)
            {
                foreach (Metal m in almacenMetal)
                {
                    cmbOpciones.Items.Add(m.Nombre);
                }
            }
            if (cmbCategoria.SelectedIndex == 1) {
                foreach(Madera m in almacenMadera)
                {
                    cmbOpciones.Items.Add(m.Nombre);

                }
            }
        }

        private void cmbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOpciones.Enabled = false;
            indiceOpciones = cmbOpciones.SelectedIndex;
            if (cmbCategoria.SelectedIndex == 0)
            {
                miMetal = (Metal)almacenMetal[cmbOpciones.SelectedIndex];
                txtbDensidad.Text = Convert.ToString(miMetal.Densidad);
                cmbMedidas.Text = miMetal.Medidas;
            }
            if (cmbCategoria.SelectedIndex == 1)
            {
                miMadera = (Madera)almacenMadera[cmbOpciones.SelectedIndex];
                txtbDensidad.Text = Convert.ToString(miMadera.Densidad);
                cmbMedidas.Text = miMadera.Medidas;
            }
        }

        private void cmbMedidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMedidas.Enabled = false;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            formProveedores = new Proveedores();
            formProveedores.Show();
        }
    }
}

