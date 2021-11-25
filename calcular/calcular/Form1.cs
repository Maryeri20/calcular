using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operaciones obj = new Operaciones();

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (!obj.IsNumeric(txtNum1.Text)&& obj.IsNumeric(txtNum2.Text))
            {
                txtResultado.Text = "Ingrese dos numeros";
            }
            else
            {
                int suma = obj.Suma(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
                txtResultado.Text = Convert.ToString(suma);
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {

            if (!obj.IsNumeric(txtNum1.Text) && obj.IsNumeric(txtNum2.Text))
            {
                txtResultado.Text = "Ingrese dos numeros";
            }
            else
            {
                int Resta = obj.Resta(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
                txtResultado.Text = Convert.ToString(Resta);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            if (!obj.IsNumeric(txtNum1.Text) && obj.IsNumeric(txtNum2.Text))
            {
                txtResultado.Text = "Ingrese dos numeros";
            }
            else
            {
                int Multiplicacion = obj.Multiplicación(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
                txtResultado.Text = Convert.ToString(Multiplicacion);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            if (!obj.IsNumeric(txtNum1.Text) && obj.IsNumeric(txtNum2.Text))
            {
                txtResultado.Text = "Ingrese dos numeros";
            }
            else
            {
                int Dividir = obj.División(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text));
                txtResultado.Text = Convert.ToString(Dividir);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
