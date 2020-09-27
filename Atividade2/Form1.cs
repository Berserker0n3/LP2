using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) && double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) && double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) && double.TryParse(txtNum2.Text, out numero2))
            {
                if(numero2 == 0)
                {
                    txtResultado.Text = "Não pode";
                } else
                {
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString();
                }
                
            }
            else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtNum1.Text, out numero1) && double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            } else
            {
                MessageBox.Show("Valores Inválidos!");
            }
        }
    }
}
