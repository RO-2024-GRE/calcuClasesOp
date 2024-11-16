using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcuClases
{
    public partial class CalculadoraClases : Form
    {
       
        private Clases.calculo calculo = new Clases.calculo();
        private double primero;
        private double segundo;
        private string operador;


        public CalculadoraClases()
        {
            InitializeComponent();
        }

      



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btCero_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";


        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void btDos_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void btTres_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void btCuatro_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void btCinco_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "5";
        }
      

        private void btSiete_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void btOcho_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void btNueve_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ".";
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void bTDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtPantalla.Text);
          
            double Res;
            Res = calculo.Calcular(operador, primero, segundo);
            txtPantalla.Text = Res.ToString();

        }







        private void btCE_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length == 1)
                txtPantalla.Text = "";
            else
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
        }

        private void Bt6_Click_1(object sender, EventArgs e)
        {
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
        }
    }
}
