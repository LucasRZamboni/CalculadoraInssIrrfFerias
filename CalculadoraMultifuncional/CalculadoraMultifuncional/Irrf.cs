using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMultifuncional
{
    public partial class Irrf : Form
    {
        public Irrf()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (tbDependentes.Text == "" || tbPensaoAlim.Text == "" || tbSalario.Text == "")
            {
                MessageBox.Show("Valor(es) não digitado(s) ou valor(es) incorreto(s)", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Calculos.salario = Convert.ToDouble(tbSalario.Text);
                Calculos.dependentes = Convert.ToInt32(tbDependentes.Text);
                Calculos.pensao = Convert.ToDouble(tbPensaoAlim.Text);
                //faixa = Convert.ToDouble(tbFaixa.Text);
                //inss = Convert.ToDouble(tbInss.Text); 
                //valorFinal = Convert.ToDouble(tbValorFinal.Text);


                //-------------------------------------------------------------------------------------------------------
                if (Calculos.salario >= 0 && Calculos.salario <= 1212)
                {
                    Calculos.CalculoFaixa1();


                    tbAliquota.Text = Calculos.f1 + "%";
                    lbFaixa.Text = "Faixa 1";
                    tbInss.Text = Calculos.inss.ToString("C2");
                    tbAliquotaEfetiva.Text = Calculos.aliquotaEfetiva.ToString("N2") + "%";

                }
                else if (Calculos.salario >= 1212.01 && Calculos.salario <= 2427)
                {

                    Calculos.CalculoFaixa2();

                    tbAliquota.Text = Calculos.f2 + "%";
                    lbFaixa.Text = "Faixa 2";
                    tbInss.Text = Calculos.inss.ToString("C2");
                    tbAliquotaEfetiva.Text = Calculos.aliquotaEfetiva.ToString("N2") + "%";

                }
                else if (Calculos.salario >= 2427.01 && Calculos.salario <= 3641)
                {
                    Calculos.CalculoFaixa3();

                    tbAliquota.Text = Calculos.f3 + "%";
                    lbFaixa.Text = "Faixa 3";
                    tbInss.Text = Calculos.inss.ToString("C2");
                    tbAliquotaEfetiva.Text = Calculos.aliquotaEfetiva.ToString("N2") + "%";

                }
                else if (Calculos.salario >= 3641.01 && Calculos.salario <= 7087)
                {
                    Calculos.CalculoFaixa4();

                    tbAliquota.Text = Calculos.f4 + "%";
                    lbFaixa.Text = "Faixa 4";
                    tbInss.Text = Calculos.inss.ToString("C2");
                    tbAliquotaEfetiva.Text = Calculos.aliquotaEfetiva.ToString("N2") + "%";

                }
                else if (Calculos.salario >= 7087.01)
                {
                    Calculos.CalculoTeto();

                    tbAliquota.Text = Calculos.f4 + "%";
                    lbFaixa.Text = "Teto INSS";
                    tbInss.Text = Calculos.inss.ToString("C2");
                    tbAliquotaEfetiva.Text = Calculos.aliquotaEfetiva.ToString("N2") + "%";


                }
                else
                {
                    MessageBox.Show("Valor não digitado ou valor incorreto", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //--------------------------------------------------------------------------------------------------------------
                if (Calculos.salario >= 0 && Calculos.salario <= 1903.98)
                {
                    Calculos.CalculoFaixa01();
                    tbAliquotaIRRF.Text = Calculos.f01 + "%";
                    lbDependentes.Text = Calculos.valorDependentes.ToString("C2");
                    lbIrrf.Text = "Faixa 0";
                    tbIrrf.Text = Calculos.irrf.ToString("C2");
                    tbAliquotaEfetivaIRRF.Text = Calculos.aliquotaEfetivaIrrf.ToString("N2") + "%";
                }
                else if (Calculos.salario >= 1903.99 && Calculos.salario <= 2826.65)
                {

                }
                else if (Calculos.salario >= 2826.66 && Calculos.salario <= 3751.05)
                {

                }
                else if (Calculos.salario >= 3751.06 && Calculos.salario <= 4664.68)
                {

                }
                else if (Calculos.salario >= 4668.69)
                {

                }
                else
                {
                    MessageBox.Show("Valor não digitado ou valor incorreto", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                Calculos.valorFinal = Calculos.salario - (Calculos.inss + Calculos.irrf + Calculos.valorDependentes);
                tbValorFinal.Text = Calculos.valorFinal.ToString("C2");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbAliquota.Text = "";
            tbAliquotaEfetiva.Text = "";
            tbInss.Text = "";
            tbSalario.Text = "";
            lbFaixa.Text = "";
            tbValorFinal.Text = "";
            tbDependentes.Text = "";
            tbPensaoAlim.Text = "";
        }

        private void Irrf_Load(object sender, EventArgs e)
        {

        }
    }
}
