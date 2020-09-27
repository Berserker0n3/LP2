using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
	
	public partial class Form1 : Form
	{
		double peso, altura, IMC;
		string MessageBoxMsg;
		public Form1()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void rdbmasc_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void pbimage_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (double.TryParse(mtxtpeso.Text, out peso) && double.TryParse(mtxtalt.Text, out altura))
			{
				if (rdbfem.Checked == true)
				{
					IMC = 62.1 * (altura/100) - 44.7;
					MessageBoxMsg = IMC == peso
							? "Você está com o peso ideal!" : IMC > peso
							? "Coma bastante massas e doces!" : "Regime já!";
					if (MessageBoxMsg == "Você está com o peso ideal!")
					{
						pbimage.Image = Properties.Resources.Forma;
						pbimage.Refresh();
					}
					else if (MessageBoxMsg == "Coma bastante massas e doces!")
					{
						pbimage.Image = Properties.Resources.Skeleton;
						pbimage.Refresh();
					}
					else
					{
						pbimage.Image = Properties.Resources.tumblr_piq8ioTjyZ1vr0ccm_1280;
						pbimage.Refresh();
					}
				}
				else
				{
					IMC = 72.7 * (altura / 100) - 78;
					MessageBoxMsg = IMC == peso
							? "Você está com o peso ideal!" : IMC > peso
							? "Coma bastante massas e doces!" : "Regime já!";
					if (MessageBoxMsg == "Você está com o peso ideal!")
					{
						pbimage.Image = Properties.Resources.Forma;
						pbimage.Refresh();
					}
					else if (MessageBoxMsg == "Coma bastante massas e doces!")
					{
						pbimage.Image = Properties.Resources.Skeleton;
						pbimage.Refresh();
					}
					else
					{
						pbimage.Image = Properties.Resources.tumblr_piq8ioTjyZ1vr0ccm_1280;
						pbimage.Refresh();
					}
				}
				MessageBox.Show(MessageBoxMsg);
			}
			else
			{
				MessageBox.Show("Valores Inválidos");
			}
		
	}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
