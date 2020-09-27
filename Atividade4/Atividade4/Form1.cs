using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
	public partial class Form1 : Form
	{
		double ladoA, ladoB, ladoC;
		string Result;
		public Form1()
		{
			InitializeComponent();
		}

		private void btCalc_Click(object sender, EventArgs e)
		{
			if (double.TryParse(textboxA.Text, out ladoA) && double.TryParse(textboxB.Text, out ladoB) && double.TryParse(textboxC.Text, out ladoC))
			{
				if (ladoA > Math.Abs(ladoB - ladoC) && ladoA < ladoB + ladoC && ladoB > Math.Abs(ladoA - ladoC) && ladoB < ladoA + ladoC && ladoC > Math.Abs(ladoA - ladoB) && ladoC < ladoA + ladoB)
				{
					Result = ladoA == ladoB && ladoA == ladoC && ladoB == ladoC
							? "Equilátero" : ladoA == ladoB || ladoA == ladoC || ladoB == ladoC
							? "Isóceles" : "EScaleno";
					textboxRes.Text = Result;
				}
				else
				{
					MessageBox.Show("Não forma um triângulo");
				}
			}
			else
			{
				MessageBox.Show("Insira Valores Válidos");
			}
		}
	}
}
