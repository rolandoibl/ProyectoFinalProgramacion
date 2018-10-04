using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazPago;
using BaseDatos;

namespace Materiales_NuevaGeneración
{
    public partial class Proveedores : Form, IMPago
    {
        #region Atributos
        Tarjeta formTarjeta;
        ArrayList proveedoresMetal;
        Proveedor miProveedor;
        #endregion

        public Proveedores()
        {
            InitializeComponent();
            proveedoresMetal = new ArrayList();
            proveedoresMetal.Add(new Proveedor("Shangai Corp", 456.8f, 30));
            proveedoresMetal.Add(new Proveedor("Sapco", 700.5f, 80));
            proveedoresMetal.Add(new Proveedor("Alpase", 200.86f, 200));

            foreach (Proveedor p in proveedoresMetal)
            {
                cmbProveedor.Items.Add(p.Nombre);
            }
        }
        #region Implementacion de interfaz
        public float Efectivo(float total, float efectivo)
        {
            try
            {
                if (int.Parse(txtbCantidad.Text) > int.Parse(txtbExistencia.Text))
                {
                    throw new ApplicationException("No hay suficientes en almacén");

                }
                float tot;
                tot = float.Parse(txtbPrecio.Text) * int.Parse(txtbCantidad.Text);
                return efectivo - tot;
            }

            catch (ApplicationException error)
            {
                errorProv.SetError(txtbCantidad, error.Message);
            }
            catch
            {
                errorProv.SetError(txtbCantidad, "Cantidad no válida");
            }

            return -1;
        }

        public bool Tarjeta(float total, float saldo, string NumeroTarjeta, string FechaVencimiento, string CSS)
        {
            string[] mesaño = FechaVencimiento.Split('/');
            try
            {
                if (total > saldo)
                {
                    throw new ApplicationException("Fondos insuficientes");
                }
                else if (int.Parse(mesaño[1]) < 18)
                {
                    throw new ApplicationException("Tarjeta vencida");
                }
                return true;
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message, "Problema detectado");
                return false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos incorrectos");
                return false;
            }
        }
        #endregion

        #region Eventos
        private void rdbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            txtbEfectivo.Visible = true;
        }





        private void rdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            txtbEfectivo.Visible = false;
        }

        private void formTarjeta_FormClosing(object sender, EventArgs e)
        {
            if (Tarjeta(formTarjeta.TotalPagar, formTarjeta.Saldo, formTarjeta.Numerotarjeta, formTarjeta.Fecha, formTarjeta.Cvv) == true)
            {
                MessageBox.Show("Pago exitoso");
            }
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            miProveedor = (Proveedor)proveedoresMetal[cmbProveedor.SelectedIndex];
            txtbPrecio.Text = Convert.ToString(miProveedor.Precio);
            txtbExistencia.Text = Convert.ToString(miProveedor.Stock);
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                txtbCantidad.Enabled = false;
                cmbProveedor.Enabled = false;
                float total = float.Parse(txtbCantidad.Text) * float.Parse(txtbPrecio.Text);
                lbTotal.Text = total.ToString();
                lbProveedor.Text = cmbProveedor.Text;
                lbUnidades.Text = txtbCantidad.Text;
                rdbEfectivo.Checked = true;
            }
            catch (FormatException)
            {
                errorProv.SetError(txtbCantidad, "Se necesita llenar el campo");

            }
        }

        private void rdbEfectivo_CheckedChanged_1(object sender, EventArgs e)
        {
            txtbEfectivo.Visible = true;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            bool errorEfectivo = false;
            try
            {
                if (rdbEfectivo.Checked)
                {
                    errorEfectivo = true;
                    float cambio = Efectivo(float.Parse(lbTotal.Text), float.Parse(txtbEfectivo.Text));
                    MessageBox.Show("$" + cambio.ToString(), "CAMBIO");
                }
                else if (rdbTarjeta.Checked)
                {
                    float TotalPagar = float.Parse(lbTotal.Text);
                    formTarjeta = new Tarjeta(TotalPagar);
                    formTarjeta.Show();
                    formTarjeta.FormClosing += new FormClosingEventHandler(formTarjeta_FormClosing);
                }
                errorEfectivo = false;
            }
            catch (FormatException)
            {
                if (errorEfectivo)
                {
                    errorProv.SetError(txtbEfectivo, "Valor incorrecto");
                }
                else
                {
                    errorProv.SetError(txtbCantidad, "Valor incorrecto");
                }

            }
        }
        #endregion
    }
}