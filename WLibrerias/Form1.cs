using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WLibrerias
{
    public partial class frmMenuOperaciones : Form
    {
        public frmMenuOperaciones()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                double Numero1 = double.Parse(txtNumero1.Text);
                double Numero2 = double.Parse(txtNumero2.Text);

                MessageBox.Show("La suma es: " + OperacionSuma.Suma.Sumar(Numero1, Numero2) + "\n" + "La resta es: " + OperacionResta.Resta.restar(Numero1, Numero2)
               + "\n" + "La multiplicacion es: " + OperacionMultiplicar.Multiplicacion.Multiplicar(Numero1, Numero2)
               + "\n" + "La divicion es: " + OperacionDivision.Division.Dividir(Numero1, Numero2)
               + "\n" + "La raiz del numero " + Numero1 + " es: " + OperacionRaizCuadrada.RaizCuadrada.SacarRaiz(Numero1, Numero2)
               + "\n" + "La raiz del numero " + Numero2 + " es: " + OperacionRaizCuadrada.RaizCuadrada.SacarRaiz2(Numero1, Numero2));
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que los datos ingresados sean numeros ");

            }


        }

        private void frmMenuOperaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Realmente desea salir?", " Comfirmacion ",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }
    }
}
