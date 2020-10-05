using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CalcBT_Click(object sender, EventArgs e)
        {
            int filhos;
            double salario, descINSS, descIRPF, salfam, salliq;
            string nome;

            nome = TXTboxName.Text;

            if(double.TryParse(TXTboxSal.Text, out salario))
            {
                if(int.TryParse(TXTboxFilhos.Text, out filhos))
                {
                    if(salario <= 800.47)
                    {
                        TXTboxAliINSS.Text = "7,65%";
                        descINSS = salario * 0.0765;

                        if (salario <= 1257.12)
                        {
                            TXTboxAliIRPF.Text = "Isento";
                            descIRPF = 0.00;

                            
                            if(salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }
                        else if (salario <= 2512.08)
                        {
                            TXTboxAliIRPF.Text = "15,0%";
                            descIRPF = salario * 0.15;


                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }
                        else
                        {
                            TXTboxAliIRPF.Text = "27,5";
                            descIRPF = salario * 0.275;


                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }

                    }
                    else if(salario <= 1050)
                    {
                        TXTboxAliINSS.Text = "8,65%";
                        descINSS = salario * 0.0865;

                        if (salario <= 1257.12)
                        {
                            TXTboxAliIRPF.Text = "Isento";
                            descIRPF = 0.00;


                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }
                        else if (salario <= 2512.08)
                        {
                            TXTboxAliIRPF.Text = "15,0%";
                            descIRPF = salario * 0.15;


                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }
                        else
                        {
                            TXTboxAliIRPF.Text = "27,5";
                            descIRPF = salario * 0.275;


                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }
                    }
                    else if(salario <= 1400.77)
                    {
                        TXTboxAliINSS.Text = "9,00%";
                        descINSS = salario * 0.09;

                        if (salario <= 1257.12)
                        {
                            TXTboxAliIRPF.Text = "Isento";
                            descIRPF = 0.00;


                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }
                        else if (salario <= 2512.08)
                        {
                            TXTboxAliIRPF.Text = "15,0%";
                            descIRPF = salario * 0.15;


                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }
                        else
                        {
                            TXTboxAliIRPF.Text = "27,5";
                            descIRPF = salario * 0.275;


                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }

                    }
                    else if(salario <= 2801.56)
                    {
                        TXTboxAliINSS.Text = "11,00%";
                        descINSS = salario * 0.11;

                        if (salario <= 1257.12)
                        {
                            TXTboxAliIRPF.Text = "Isento";
                            descIRPF = 0.00;


                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }
                        else if (salario <= 2512.08)
                        {
                            TXTboxAliIRPF.Text = "15,0%";
                            descIRPF = salario * 0.15;

                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }
                        else
                        {
                            TXTboxAliIRPF.Text = "27,5";
                            descIRPF = salario * 0.275;

                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }
                    }
                    else
                    {
                        TXTboxAliINSS.Text = "308.17";
                        descINSS = 308.17;
                        if (salario <= 1257.12)
                        {
                            TXTboxAliIRPF.Text = "Isento";
                            descIRPF = 0.00;


                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }
                        else if (salario <= 2512.08)
                        {
                            TXTboxAliIRPF.Text = "15,0%";
                            descIRPF = salario * 0.15;


                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }
                        else
                        {
                            TXTboxAliIRPF.Text = "27,5";
                            descIRPF = salario * 0.275;


                            if (salario <= 435.52)
                            {
                                salfam = 22.33 * filhos;
                            }
                            else if (salario <= 654.61)
                            {
                                salfam = 15.74 * filhos;
                            }
                            else
                            {
                                salfam = 0;
                            }
                        }

                    }
                    salliq = salario - descINSS - descIRPF + salfam;

                    TXTboxSalFam.Text = salfam.ToString();
                    TXTboxSalLiq.Text = salliq.ToString();
                    TXTboxDescINSS.Text = descINSS.ToString();
                    TXTboxDescIRPF.Text = descIRPF.ToString(); 
                    if (CboxCasado.Checked == true)
                    {
                        if (RDBFem.Checked == true)
                        {
                            TXTboxResult.Text = "Os Descontos do Salário da Sra. " + nome + ". Que é casada e tem " + filhos.ToString() + " filhos:";
                        }
                        else if (RDBMasc.Checked == true)
                        {
                            TXTboxResult.Text = "Os Descontos do Salário do Sr. " + nome + ". Que é casado e tem " + filhos.ToString() + " filhos:";
                        }
                    }
                    else
                    {
                        if (RDBFem.Checked == true)
                        {
                            TXTboxResult.Text = "Os Descontos do Salário da Sra. " + nome + ". Que não é casada e tem " + filhos.ToString() + " filhos:";
                        }
                        else if (RDBMasc.Checked == true)
                        {
                            TXTboxResult.Text = "Os Descontos do Salário do Sr. " + nome + ". Que não é casado e tem " + filhos.ToString() + " filhos:";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Insira um Valor Válido");
                }
            }
            else
            {
                MessageBox.Show("Insira um Valor Válido");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
