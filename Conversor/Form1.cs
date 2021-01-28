using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            double Valor1;
            double Valor2 = 5.43;
            double result;
            

            try
            {
                Valor1 = Convert.ToDouble(txtBox1.Text);
               // Valor2 = Convert.ToDouble(txtBox2.Text);

                result = Valor1 * Valor2;

               

                MessageBox.Show("O Dolar está sendo negóciado à: " + result);
                txtBox1.Clear();

            }
            catch(FormatException)
            {
                MessageBox.Show("Erro! Digite apenas numeros!");
                txtBox1.Clear();
                txtBox2.Clear();
            }
            


            //lbText.Text += txtBox1.Text;
        }

        private void btnConvert1_Click(object sender, EventArgs e)
        {
            double ValorReal = 0.18;
            double Valor2;
            double result;
            try
            {
                Valor2 = Convert.ToDouble(txtBox2.Text);
                // Valor2 = Convert.ToDouble(txtBox2.Text);

                result = Valor2 * ValorReal;

                MessageBox.Show("O Real está sendo negociado à:" + result);
                txtBox2.Clear();

            }
            catch (FormatException)
            {
                MessageBox.Show("Erro! Digite apenas numeros!");
                txtBox1.Clear();
                txtBox2.Clear();
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
