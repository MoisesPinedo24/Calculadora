using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double variable1;
        private double variable2;

        private double resultado;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string num1 = "10";
            string num2 = "15";

            int resultado = 0;
            int variable1 = 0;
            int variable2 = 0;
            
            variable1 = Convert.ToInt32(num1);
            variable2 = Convert.ToInt32(num2);  

            resultado = variable1 + variable2;

            Pantalla.Text = resultado.ToString();

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            variable1 = Convert.ToDouble(Pantalla.Text);
            Pantalla.Text = "";

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {

        }

        private void btnPorciento_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarPant_Click(object sender, EventArgs e)
        {
            Pantalla.Text = "";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            {
                // Verifica si ya hay un punto en el nuero actual
                if (!Pantalla.Text.Contains("."))
                {
                    // Concatena un punto al número actual en la pantalla de la calculadora
                    Pantalla.Text += ".";
                }
            }
        }
    }
}
