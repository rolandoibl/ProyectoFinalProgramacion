using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materiales_NuevaGeneración
{
    public partial class Tarjeta : Form
    {
        private string numerotarjeta;
        private string cvv;
        private string fecha;
        private float totalPagar;
        private float saldo;

        public Tarjeta(float TotalPagar)
        {
            InitializeComponent();
            this.totalPagar = TotalPagar;
            lbTotalPagar.Text = this.totalPagar.ToString();
        }

        public string Numerotarjeta { get => numerotarjeta; set => numerotarjeta = value; }
        public string Cvv { get => cvv; set => cvv = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public float TotalPagar { get => totalPagar; set => totalPagar = value; }
        public float Saldo { get => saldo; set => saldo = value; }

        private void btnFinalizarTransaccion_Click(object sender, EventArgs e)
        {

            Random saldovariable = new Random();
            Numerotarjeta = mtbNumeroTarjeta.Text;
            Cvv = mtbCvv.Text;
            Fecha = mtbVencimiento.Text;
            Saldo = (float)saldovariable.NextDouble() * 1000;

            this.Close();

        }
    }
}
